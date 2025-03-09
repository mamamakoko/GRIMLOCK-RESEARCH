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

// First, get the latest user_id
$query = "SELECT attendance.user_id, 
                 CONCAT(users_info.first_name, ' ', users_info.last_name) AS name, 
                 CONCAT(programs.program_name, ' ', user_program_section_year.year, sections.section_name) AS section
          FROM attendance 
          INNER JOIN users_info ON attendance.user_id = users_info.user_id
          INNER JOIN user_program_section_year ON users_info.user_id = user_program_section_year.user_id
          INNER JOIN programs ON user_program_section_year.program_id = programs.program_id
          INNER JOIN sections ON user_program_section_year.section_id = sections.section_id
          ORDER BY COALESCE(attendance.updated_at, attendance.created_at) DESC 
          LIMIT 1;";

// Execute the query to get the latest user details
$result = $conn->query($query);

// Check if any rows were returned
if ($result->num_rows > 0) {
    // Fetch the row for user details
    $user_row = $result->fetch_assoc();

    // Get the user_id for fetching attendance data
    $user_id = $user_row['user_id'];

    // Fetch general attendance records (time_in, time_out) for this user
    $attendance_query = "SELECT CONCAT(DATE(attendance.created_at), ' ', attendance.time_in) AS time_in_date, 
                                IFNULL(CONCAT(DATE(attendance.updated_at), ' ', attendance.time_out), '-') AS time_out_date
                         FROM attendance 
                         WHERE user_id = '$user_id' 
                         ORDER BY created_at DESC;";

    // Execute the query to get attendance records
    $attendance_result = $conn->query($attendance_query);

    // Create an array to hold attendance records
    $attendance_data = array();

    // Fetch all attendance records
    if ($attendance_result->num_rows > 0) {
        while ($attendance_row = $attendance_result->fetch_assoc()) {
            $attendance_data[] = $attendance_row;
        }
    } else {
        // If no attendance records found, return "-"
        $attendance_data[] = array(
            'time_in_date' => "-",
            'time_out_date' => "-"
        );
    }

    // Add the general attendance and updated time_out records to the user row
    $user_row['attendance'] = $attendance_data;

    // Return the data as JSON
    echo json_encode($user_row);

} else {
    // If no user data found, return "-"
    echo json_encode(array(
        'user_id' => "-",
        'name' => "-",
        'section' => "-",
        'attendance' => array(array(
            'time_in_date' => "-",
            'time_out_date' => "-"
        )),
        'updated_time_out' => array(array(
            'time_in_date' => "-",
            'time_out_date' => "-"
        ))
    ));
}

// Close connection
$conn->close();
?>
