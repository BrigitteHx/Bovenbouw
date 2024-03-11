<?php
function ageCalculator(int $bornYear){
    $age = 2023 - $bornYear ;
    return "Your age is = $age years old.";
}
echo ageCalculator('2004'); // Here php will see it as int and will not get an error
// but if we use -> declare(strict_types=1); , you will get an error! look at the below example
?>

<!-- declare(strict_types=1);
function addNumbers(int $a, int $b) {
  return $a + $b;
}
echo addNumbers(5, "5 days");
// since strict is enabled and "5 days" is not an integer, an error will be thrown -->
