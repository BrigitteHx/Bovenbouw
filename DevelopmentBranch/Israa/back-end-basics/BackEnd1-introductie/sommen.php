<?php
function sommen($operator){
    $random_nummer1 = rand(0,100);
    $random_nummer2 = rand(0,100);

    if(strtolower($operator) == "vermenigvuldiging"){
        echo("vermenigvuldiging $random_nummer1 * $random_nummer2 = " . $random_nummer1 * $random_nummer2 );
    } else if (strtolower($operator) == "optelsom"){
        echo("optelsom $random_nummer1 + $random_nummer2 = " . $random_nummer1 + $random_nummer2 );
    } else if (strtolower($operator) == "aftreksom"){
        echo("aftreksom $random_nummer1 - $random_nummer2 = " . abs($random_nummer1 - $random_nummer2) );
    } else if (strtolower($operator) == "deelsom"){
        echo("deelsom $random_nummer1 / $random_nummer2 = " . abs($random_nummer1 / $random_nummer2) );
    }
};

sommen('aftreksom');