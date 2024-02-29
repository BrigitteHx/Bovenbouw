<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="madlibs.css" />

</head>
<body>
    <?php
        $requiredInput = "";
        $invalidInput = "";
        $filled_information = array();
        $story = "";

        if ($_SERVER["REQUEST_METHOD"] == "POST") {
                // Required field = 
            
            for ($x = 1; $x <= 8; $x++) {
                if(empty($_POST["vraag$x"])){
                    $requiredInput = "* Required field";
                } if (ctype_alpha(str_replace(' ', '', $_POST["vraag$x"])) === false) {
                    $invalidInput = "Input is Invalid!</br>";
                } else {
                    array_push($filled_information, $_POST["vraag$x"]);
                }
            }
            $length = count($filled_information);
            if ($length == 8) {
                $story = "</br><h3>Jouw verhaal:</h3> <p></br>Er heerst paniek in het koninkrijk $filled_information[2].Koning $filled_information[5] is ten einde raad als koning $filled_information[5] ten einde raad is, dan roept hij zijn ten-einde-raadscheer $filled_information[1].</br> '$filled_information[1]! Het Is een ramp! Het is een schande!'</br> 'Sire, Majesteit, uwe Luidruhtigheid, wat is er aan de hand?' </br> 'Mijn $filled_information[0] is verdwenen! Zo maar, zonder waarschuwing. En ik had net $filled_information[4] voor hem gekocht!' </br> 'Majesteit, uw $filled_information[0] komt vast vanzelf weer terug.' </br> 'Ja, da's leuk en aardig, maar hoe moet ik in de tussentijd $filled_information[7]?'</br> 'Maar sir, daar kunt u toch $filled_information[6] voor gebruiken.'</br>'$filled_information[1], je hebt helemaal gelijk! Wat zou ik doen als jou niet had.</br>'$filled_information[3], Sire.'</p>";
            }
        }
        ?>


    <div id="formulier"> 
        <button onclick="location.href = 'madLibs.php';" class="dropbtn">Home</button>
        <button onclick="location.href = 'heerst_paniek.php';" class="dropbtn">Er heerst paniek</button>
        <button onclick="location.href = 'onkunde.php';" class="dropbtn">Onkunde</button>


        <h1> Er heerst paniek </h1>
        <form method="post" >
        Welke dier zou je nooit als huisdier willen hebben? <input type="text" name="vraag1">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wie is de belangrijkste persoon in je leven? <input type="text" name="vraag2">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        In welke land zou je graag willen wonen? <input type="text" name="vraag3">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat doe je als je verveelt? <input type="text" name="vraag4">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Met welke speelgoed speelde je als je kind het meeste? <input type="text" name="vraag5">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Bij welke docent spijbel je het liefst? <input type="text" name="vraag6">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>
        Als je 100.00,- had, wat zou je dan kopen? <input type="text" name="vraag7">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat is je favoriete bezigheid? <input type="text" name="vraag8">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        <input type="submit" name="madlib" value="Create story!">
        </form>
        
        <?php 
            echo $story;
        ?>
    
        <footer>&copy; Copyright 2023 made by Israa.</footer>
    </div>
</body>
</html>