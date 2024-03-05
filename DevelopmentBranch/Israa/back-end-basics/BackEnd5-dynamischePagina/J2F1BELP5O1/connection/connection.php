<?php
function connect()
{
    try {
        $serveraddress = "localhost";
        $dbname = "databank_php";
        $username = "root";
        $password = "";

        $conn = new PDO("mysql:host=$serveraddress;dbname=$dbname", $username, $password);
       
        // Set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        return $conn; // Return the PDO connection object
    } catch(PDOException $e) {
        echo "Connection failed: " . $e->getMessage();
        return null;
    }
}

// Call the connect function to establish a database connection
$pdo = connect();
