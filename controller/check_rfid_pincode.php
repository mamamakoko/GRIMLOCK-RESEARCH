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

// Retrieve data from the GET request
if (isset($_GET['tag'])) {
    $rfid_tag = $_GET['tag'];
    
    if (isset($_GET['pincode']) && !empty($_GET['pincode'])) {
        $pincode = $_GET['pincode'];
        
        // Check if the RFID tag and pincode exist and match in the database
        $sql_check = "SELECT ua.pin_code 
                      FROM user_accounts ua
                      JOIN users_info ui ON ua.user_id = ui.user_id
                      JOIN smart_card_data scd ON ui.user_id = scd.user_id
                      WHERE scd.rfid_code = '$rfid_tag' AND ua.pin_code = '$pincode'";
        
        $result = $conn->query($sql_check);
        
        if ($result->num_rows > 0) {
            // RFID tag and pincode match
            echo "exists";
        } else {
            // RFID tag and pincode do not match or not found
            echo "not found";
        }
    } 
} else {
    echo "No RFID tag received.";
}

$conn->close();
?>
