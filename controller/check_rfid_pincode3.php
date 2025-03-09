<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gsdb";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

if (isset($_GET['tag'])) {
    $rfid_tag = $_GET['tag'];

    //  Checks role of the user upon tapping
    $check_role = "SELECT user_accounts.role
                    FROM user_accounts
                    INNER JOIN users_info ON user_accounts.user_id = users_info.user_id
                    INNER JOIN smart_card_data ON users_info.user_id = smart_card_data.user_id
                    WHERE smart_card_data.rfid_code = '$rfid_tag'";

    $result_role = $conn->query($check_role);

    if ($result_role->num_rows > 0) {
        // Fetch the role from the query result
        $row = $result_role->fetch_assoc();
        $role = $row['role'];

        // if ($role == 'instructor' || $role == 'admin' || $role == 'technician' || $role == 'staff' || $role == 'guest') {
            // echo "need pincode";

            // // Poll for the pincode
            // $pincode = null;
            // $timeout = 30; // Timeout in seconds
            // $start_time = time();

            // while (true) {
            //     // Check for pincode (Arduino sends this as a new GET request with 'pincode' parameter)
            //     if (isset($_GET['pincode'])) {
            //         $pincode = $_GET['pincode'];
            //         break;
            //     }

            //     // Timeout logic
            //     if (time() - $start_time > $timeout) {
            //         // echo "Pincode timeout. No response from Arduino.";
            //         echo "pincode timeout";
            //         exit;
            //     }

            //     // Sleep for a short period to avoid hammering the server
            //     usleep(200000); // 200ms
            // }

            // // Process the received pincode
            // if ($pincode) {
            //     // Validate the pincode or take necessary actions
            //     // echo "Received pincode: $pincode"; // For debugging purposes

            //     // Check if the RFID tag and pincode exist and match in the database
            //     $check_pincode = "SELECT ua.pin_code 
            //     FROM user_accounts ua
            //     JOIN users_info ui ON ua.user_id = ui.user_id
            //     JOIN smart_card_data scd ON ui.user_id = scd.user_id
            //     WHERE scd.rfid_code = '$rfid_tag' AND ua.pin_code = '$pincode'";

            //     $pincode_result = $conn->query($check_pincode);

            //     if ($pincode_result->num_rows > 0) {
            //         // RFID tag and pincode match
            //         echo "exists";
            //     } else {
            //         // RFID tag and pincode do not match or not found
            //         echo "not found";
            //     }
            // }
  
        if (in_array($role, ['instructor', 'admin', 'technician', 'staff', 'guest'])) {
            // Request pincode from Arduino
            // if (!isset($_GET['pincode'])) {
            //     echo "need pincode";
            //     exit;
            // }

            // // Process the received pincode
            // $pincode = $_GET['pincode'];
            // $check_pincode = "SELECT ua.pin_code FROM user_accounts ua 
            //                   JOIN users_info ui ON ua.user_id = ui.user_id 
            //                   JOIN smart_card_data scd ON ui.user_id = scd.user_id 
            //                   WHERE scd.rfid_code = '$rfid_tag' AND ua.pin_code = '$pincode'";
            // $pincode_result = $conn->query($check_pincode);

            // if ($pincode_result->num_rows > 0) {
            //     echo "exists"; // Pincode matched
            // } else {
            //     echo "not found"; // Pincode incorrect
            // }

            echo "access granted";

        } elseif ($role == 'student') {
            echo "student";

            // Check if the instructor is inside the classroom
            $check_instructor =
                "SELECT * FROM attendance
                INNER JOIN users_info
	                ON attendance.user_id = users_info.user_id
                INNER JOIN user_course AS instructor
	                ON users_info.user_id = instructor.user_id
                INNER JOIN schedule
	                ON instructor.user_course = schedule.user_course
                WHERE CURRENT_TIME() BETWEEN schedule.start_time AND schedule.end_time
	                AND schedule.day = LOWER(DAYNAME(CURRENT_DATE()))
                    AND YEAR(CURRENT_DATE()) BETWEEN schedule.start_year AND schedule.end_year
                    AND attendance.time_out IS NULL
                    ;";

            $check_schedule =
                "SELECT smart_card_data.rfid_code, users_info.user_id, schedule.schedule_id, schedule.start_time
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
                WHERE smart_card_data.rfid_code = '$rfid_tag'
                AND schedule.day = LOWER(DAYNAME(CURRENT_DATE()))
                AND CURRENT_TIME() BETWEEN schedule.start_time AND schedule.end_time
                AND YEAR(CURRENT_DATE()) BETWEEN schedule.start_year AND schedule.end_year;
                ";

            $result_schedule = $conn->query($check_schedule);
            $result_instructor = $conn->query($check_instructor);

            // Check if the student has schedule and the instructor is inside the classroom
            if ($result_schedule->num_rows>0 && $result_instructor->num_rows>0) {
                echo "student granted";

                $check_info = 
                    "SELECT smart_card_data.rfid_code, users_info.user_id, schedule.schedule_id, schedule.start_time
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
                    WHERE smart_card_data.rfid_code = '$rfid_tag'
                        AND schedule.day = LOWER(DAYNAME(CURRENT_DATE()))
                        AND CURRENT_TIME() BETWEEN schedule.start_time AND schedule.end_time
                        AND YEAR(CURRENT_DATE()) BETWEEN schedule.start_year AND schedule.end_year;
                    ";
                $result_info = $conn->query($check_info);

                if ($result_info->num_rows > 0) {
                    $row_info = $result_info->fetch_assoc();
                    $schedule_id = $row_info['schedule_id'];
                    $user_id = $row_info['user_id'];
                    $start_time = $row_info['start_time'];
                    $current_time = new DateTime(); // Get the current timestamp
                
                    // Check if an attendance record exists for the user and schedule where time_out is NULL
                    $check_sql = "SELECT * FROM attendance 
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
                
                    if ($check_result->num_rows == 0) {
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
                
                        $insert_time_in  = mysqli_query($conn,"INSERT INTO `attendance`(`schedule_id`, `user_id`, `status`) VALUES ('".$schedule_id."','".$user_id."','".$status."')");
                
                        if ($insert_time_in==true)
                        {
                            echo "Time-in recorded successfully with status: $status.";
                            echo "Time-in recorded successfully!";
                        } else {
                            echo "Error recording time-in: " . $insert_stmt->error;
                        }
                
                    }
                
                    $check_stmt->close();
                }
            } else {
                echo "student denied";
            }
        } 

        // echo "The selected role is: " . $role;
    } else {
        // echo "No role found for this RFID tag.";
        echo "no role found";
    }
}

$conn->close();
?>
