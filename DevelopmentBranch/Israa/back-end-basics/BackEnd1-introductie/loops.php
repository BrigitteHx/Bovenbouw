<!-- http://localhost/back-end-basics/introductie/loops.php -->
<!--
    $colors = array("red", "green", "blue", "yellow");

    foreach ($colors as $value) {
    echo "$value <br>";
    }
 -->

<?php
$age = array("Barka"=>"35", "Jimin"=>"37", "Inyeop"=>"35");

foreach($age as $key => $value) {
  echo "$key is $value old.<br>";
}
?>