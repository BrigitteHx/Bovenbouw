<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            text-align: center;
        }
        img {
            width: 250px;            
        }
    </style>
</head>
<body>
    <?php
    require "content.php";
    echo"Hello, My name is $name $surename<br>";
    echo "$text <br>";
    ?>
    <img src="<?php echo $image;?>">
</body>
</html>