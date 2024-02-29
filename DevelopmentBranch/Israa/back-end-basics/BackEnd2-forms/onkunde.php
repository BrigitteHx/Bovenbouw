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
            
            for ($x = 1; $x <= 7; $x++) {
                if(empty($_POST["vraag$x"])){
                    $requiredInput = "* Required field";
                } if (ctype_alpha(str_replace(' ', '', $_POST["vraag$x"])) === false) {
                    $invalidInput = "Input is Invalid!</br>";
                } else {
                    array_push($filled_information, $_POST["vraag$x"]);
                }
            }
            $length = count($filled_information);
            if ($length == 7) {
                $story = "</br><h3>Jouw verhaal:</h3> <p></br>Er zijn veel mensen die niet kunnen $filled_information[0]. Neem nou $filled_information[1]. Zelfs met behulp van een $filled_information[3] of zelfs $filled_information[2] kan $filled_information[1] niet $filled_information[0]. Dat heeft niet te maken met een gebrek aan $filled_information[4], maar met een te veel aan $filled_information[5]. Te veel $filled_information[5] leidt tot veel $filled_information[6] en dat is niet goed als je wilt $filled_information[0]. Helaas voor $filled_information[1].  </p>";
            }
        }
        ?>

    <div id="formulier"> 
        <button onclick="location.href = 'madLibs.php';" class="dropbtn">Home</button>
        <button onclick="location.href = 'heerst_paniek.php';" class="dropbtn">Er heerst paniek</button>
        <button onclick="location.href = 'onkunde.php';" class="dropbtn">Onkunde</button>

        <h1> Onkunde </h1>
        <form method="post" >
        Wat zou je graag willen kunnen?<input type="text" name="vraag1">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Met welke persoon kun je goed opschieten? <input type="text" name="vraag2">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat is je favoriete getal?<input type="text" name="vraag3">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat heb je altijd bij je als je op vakantie gaat?<input type="text" name="vraag4">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat is je beste persoonlijke eigenschappen? <input type="text" name="vraag5">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat is je slechtste persoonlijke eigenschappen?<input type="text" name="vraag6">
        <span class="error"><?php echo $requiredInput;?></span>
        <br />
        <span class="error"><?php echo $invalidInput;?></span>

        Wat is het ergste dat je kan overkomen? <input type="text" name="vraag7">
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