<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>All Characters</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="resources/css/style.css" rel="stylesheet"/>
</head>
<body>
<header><h1>Alle characters uit de database</h1></header>

<div id="container">
    <?php
    // Include database connection
    require 'connection/connection.php';

    // Fetch characters from the database
    $query = $pdo->query("SELECT * FROM characters ORDER BY `name`");
    $characters = $query->fetchAll(PDO::FETCH_ASSOC);

    // Check if characters are fetched
    if ($characters) {
        foreach ($characters as $character):
    ?>
        <a class="item" href="character.php?id=<?php echo $character['id']; ?>">
            <div class="left">
                <img class="avatar" src="resources/images/<?php echo $character['avatar']; ?>">

            </div>
            <div class="right">
                <h2><?php echo $character['name']; ?></h2>
                <div class="stats">
                    <ul class="fa-ul">
                        <li><span class="fa-li"><i class="fas fa-heart"></i></span> <?php echo $character['health']; ?></li>
                        <li><span class="fa-li"><i class="fas fa-fist-raised"></i></span> <?php echo $character['attack']; ?></li>
                        <li><span class="fa-li"><i class="fas fa-shield-alt"></i></span> <?php echo $character['defense']; ?></li>
                    </ul>
                </div>
            </div>
            <div class="detailButton"><i class="fas fa-search"></i> bekijk</div>
        </a>
    <?php
        endforeach;
    } else {
        echo "Geen characters gevonden.";
    }
    ?>
</div>

<footer>&copy; Israa 2023</footer>
</body>
</html>
