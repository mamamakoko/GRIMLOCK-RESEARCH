<?php
date_default_timezone_set('Asia/Manila');

// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gsdb9";

$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Validate RFID tag input
if (isset($_GET['tag']) && !empty($_GET['tag'])) {
    $rfid_tag = $_GET['tag'];
} else {
    die("RFID tag is not provided.");
}

// Prepare the SQL query to fetch the necessary information
$sql = "
    SELECT smart_card_data.rfid_code, users_info.user_id, schedule.schedule_id, schedule.start_time
    FROM smart_card_data
    INNER JOIN users_info
        ON users_info.user_id = smart_card_data.user_id
    INNER JOIN student_courses
        ON student_courses.user_id = users_info.user_id
    INNER JOIN user_course
        ON student_courses.user_course = user_course.user_course
    INNER JOIN users_info AS instructor
        ON user_course.user_id = instructor.user_id 
    INNER JOIN programs
        ON programs.program_id = user_course.program_id
    INNER JOIN sections
        ON sections.section_id = user_course.section_id
    INNER JOIN schedule
        ON user_course.user_course = schedule.user_course
    WHERE smart_card_data.rfid_code = ?
    AND schedule.day = LOWER(DAYNAME(CURRENT_DATE()))
    AND CURRENT_TIME() BETWEEN schedule.start_time AND schedule.end_time
    AND YEAR(CURRENT_DATE()) BETWEEN schedule.start_year AND schedule.end_year;
";

// Prepare and bind
$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $rfid_tag);

// Execute the query
$stmt->execute();
$result = $stmt->get_result();

// Check if there are any matching rows
if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $schedule_id = $row['schedule_id'];
    $user_id = $row['user_id'];
    $start_time = $row['start_time'];
    $current_time = new DateTime(); // Get the current timestamp

    // Check if an attendance record exists for the user and schedule where time_out is NULL
    $check_sql = "
        SELECT * FROM attendance 
        INNER JOIN users_info ON attendance.user_id = users_info.user_id
        INNER JOIN smart_card_data ON users_info.user_id = smart_card_data.user_id
        WHERE attendance.schedule_id = ?
            AND attendance.user_id = ?
            AND attendance.time_out IS NULL
            AND smart_card_data.rfid_code = '$rfid_tag'
    ";

    $check_stmt = $conn->prepare($check_sql);
    $check_stmt->bind_param("ii", $schedule_id, $user_id);
    $check_stmt->execute();
    $check_result = $check_stmt->get_result();

    if ($check_result->num_rows > 0) {
        // If a record exists, update time_out
        $time_out = $current_time->format('Y-m-d H:i:s');
        $update_sql = "
            UPDATE attendance
            INNER JOIN users_info ON attendance.user_id = users_info.user_id
            INNER JOIN smart_card_data ON users_info.user_id = smart_card_data.user_id
            SET attendance.time_out = ?, attendance.updated_at = CURRENT_TIMESTAMP
            WHERE schedule_id = ?
                AND attendance.user_id = ?
                AND attendance.time_out IS NULL
                AND smart_card_data.rfid_code = '$rfid_tag'
        ";

        $update_stmt = $conn->prepare($update_sql);
        $update_stmt->bind_param("sii", $time_out, $schedule_id, $user_id);

        if ($update_stmt->execute()) {
            echo "Time-out recorded successfully.";
        } else {
            echo "Error updating time-out: " . $update_stmt->error;
            echo "Error updating time-out!";
        }

        $update_stmt->close();
    } else {
        // If no record exists, insert time_in and determine status
        $start_time_dt = new DateTime($start_time); // Convert start_time to DateTime object
        $time_diff = $current_time->getTimestamp() - $start_time_dt->getTimestamp(); // Difference in seconds

        // Convert the difference from seconds to minutes
        $time_diff_minutes = round($time_diff / 60); // Difference in minutes

        // Determine status based on the time difference
        if ($time_diff_minutes <= 15) {
            $status = 'present';
        } elseif ($time_diff_minutes <= 30) {
            $status = 'late';
        } else {
            $status = 'absent';
    }

        $time_in = $current_time->format('Y-m-d H:i:s'); // Format current time for insertion

        $insert_sql1  = mysqli_query($conn,"INSERT INTO `attendance`(`schedule_id`, `user_id`, `status`) VALUES ('".$schedule_id."','".$user_id."','".$status."')");

        if ($insert_sql1==true)
        {
            echo "Time-in recorded successfully with status: $status.";
            echo "Time-in recorded successfully!";
        } else {
            echo "Error recording time-in: " . $insert_stmt->error;
        }

    }

    $check_stmt->close();
} else {
    echo "No matching schedule found for the provided RFID.";
}

// Close connection
$stmt->close();
$conn->close();
?>
