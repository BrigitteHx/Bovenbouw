<?php
    function greeting_message(){
        $timeOfDay = date("H:i a");
        if($timeOfDay >= ('06:00 am') && $timeOfDay < ('12:00 pm')){
            $greeting = 'Good morning!<br> Het is nu '.$timeOfDay;
        } else if($timeOfDay >= ('12:00 pm') && $timeOfDay < ('18:00 pm')){
            $greeting = 'Good afternoon!<br> Het is nu '.$timeOfDay;
        } else if( $timeOfDay >= ('18:00 pm') && ($timeOfDay) < ('00:00 am')){
            $greeting = 'Good evening!<br> Het is nu '.$timeOfDay;
        } else {
            $greeting = 'Good night!<br> Het is nu '. $timeOfDay;
        }
        return $greeting;
    } 

    function background_image(){
        $timeOfDay = date("H:i a"); 
        if($timeOfDay >= ('06:00 am') && $timeOfDay < ('12:00 pm')){
            return 'images/morning.png';
        } else if($timeOfDay >= ('12:00 pm') && $timeOfDay < ('18:00 pm')){
            return 'images/afternoon.png';
        } else if( $timeOfDay >= ('18:00 pm') && ($timeOfDay) < ('00:00 am')){
            return 'images/evening.png';
        } else {
            return 'images/night.png';
        }
    }
?>  
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Date Time</title>
    <style>
        @import url('https://fonts.googleapis.com/css?family=Lobster');  
        body {
            background-image: url('<?php echo background_image(); ?>');
            background-repeat: no-repeat;
            background-size: 100%;
        }
        .centered {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            color: white;
            font-family: Lobster;  
        }
    </style>
</head>
<body>
    <div class="centered">
        <h1><?php echo greeting_message();?></h1>
    </div>
</body>
</html>
