<?php

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "gsdb9";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$rfid_tag = $_GET['tag'];
$ip_address = $_SERVER['REMOTE_ADDR'] == '::1' ? '127.0.0.1' : $_SERVER['REMOTE_ADDR'];

$sql = "
  INSERT INTO access_logs (user_id, instructor_id, ip_address, activity, course, section, date, time, laboratory, created_at, updated_at)
  SELECT users_info.user_id, users_info.user_id, '$ip_address', 'Login', 'N/A',  'N/A',  CURDATE(), CURTIME(), 'NAS Lab', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
  FROM smart_card_data
  INNER JOIN users_info
    ON users_info.user_id = smart_card_data.user_id
    WHERE smart_card_data.rfid_code = '$rfid_tag';
";


if ($conn->query($sql) === TRUE) {
  echo "Access log recorded!";
} else {
  // echo "Error: " . $sql . "<br>" . $conn->error;
  echo "Access log failed!";
}

$conn->close();
?>