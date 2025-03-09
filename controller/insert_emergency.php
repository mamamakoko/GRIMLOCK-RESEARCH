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

// Get inputs and sanitize them
$type = isset($_GET['type']) ? $_GET['type'] : '';
$lab = isset($_GET['laboratory']) ? $_GET['laboratory'] : '';

// Prepared statements to prevent SQL injection
$stmt = $conn->prepare("INSERT INTO emergency (emergency_log, emergency_type, laboratory) VALUES (NOW(), ?, ?)");
$stmt->bind_param("ss", $type, $lab);

if ($stmt->execute()) {
    echo "Emergency log recorded!";
} else {
    echo "Error: " . $stmt->error;
}

// Close the statement and connection
$stmt->close();
$conn->close();
?>
