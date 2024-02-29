
<?php
$numbers = array(3,5,8,12);

function  multiplication_tables($number){
    echo "De tafel van $number <br/>";
    for ($num = 0; $num <= 10; $num++) {
        echo "$number x $num   = " .$number * $num ."<br/>" ;
    };
};

foreach($numbers as $key) {
    multiplication_tables($key);
    echo "<br/>";
  }