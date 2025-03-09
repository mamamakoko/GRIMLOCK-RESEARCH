<?php

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gsdb";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$rfid_tag = $_GET['tag'];
$ip_address = $_SERVER['REMOTE_ADDR'] == '::1' ? '127.0.0.1' : $_SERVER['REMOTE_ADDR'];

$sql = "
  INSERT INTO access_logs (user_id, instructor_id, ip_address, activity, course, section, date, time, laboratory, created_at, updated_at)
  SELECT users_info.user_id,  .user_id AS instructor, '$ip_address', 'Login', courses.course_name, CONCAT(programs.program_name, ' ', user_course.year, ' ', sections.section_name) AS Section,  CURDATE(), CURTIME(), 'NAS Lab', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
  FROM smart_card_data
  INNER JOIN users_info
    ON users_info.user_id = smart_card_data.user_id
  INNER JOIN student_courses
    ON student_courses.user_id = users_info.user_id
  INNER JOIN user_course
    ON student_courses.user_course = user_course.user_course
  INNER JOIN courses
    ON user_course.course_code = courses.course_code
  INNER JOIN users_info AS instructor
    ON user_course.user_id = instructor.user_id 
  INNER JOIN programs
    ON programs.program_id = user_course.program_id
  INNER JOIN sections
    ON sections.section_id = user_course.section_id
  INNER JOIN schedule
    ON user_course.user_course = schedule.user_course
  WHERE smart_card_data.rfid_code = '$rfid_tag'
  AND NOT EXISTS (
      SELECT 1 FROM access_logs
      WHERE access_logs.user_id = users_info.user_id
        AND access_logs.date = CURRENT_DATE()
        AND access_logs.time BETWEEN schedule.start_time AND schedule.end_time
  );
";


if ($conn->query($sql) === TRUE) {
  echo "Access log recorded!";
} else {
  // echo "Error: " . $sql . "<br>" . $conn->error;
  echo "Access log failed!";
}

$conn->close();
?>