<?php
require 'connection/connection.php';

// Check if character ID is provided in the URL
if (isset($_GET['id'])) {
    // Retrieve character details from the database based on the provided ID
    $characterId = $_GET['id'];
    $stmt = $pdo->prepare("SELECT * FROM characters WHERE id = ?");
    $stmt->execute([$characterId]);
    $character = $stmt->fetch(PDO::FETCH_ASSOC);

    // Check if character exists
    if ($character) {
        // Character data exists, populate the page with character details
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Character - <?php echo $character['name']; ?></title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="resources/css/style.css" rel="stylesheet"/>
</head>
<body>
<header>
    <h1><?php echo $character['name']; ?></h1>
    <a class="backbutton" href="index.php"><i class="fas fa-long-arrow-alt-left"></i> Terug</a>
</header>
<div id="container">
    <div class="detail">
        <div class="left">
            <img class="avatar" src="resources/images/<?php echo $character['avatar']; ?>">
            <div class="stats" style="background-color: <?php echo $character['color']; ?>">
                <ul class="fa-ul">
                    <li><span class="fa-li"><i class="fas fa-heart"></i></span> <?php echo $character['health']; ?></li>
                    <li><span class="fa-li"><i class="fas fa-fist-raised"></i></span> <?php echo $character['attack']; ?></li>
                    <li><span class="fa-li"><i class="fas fa-shield-alt"></i></span> <?php echo $character['defense']; ?></li>
                </ul>
                <ul class="gear">
                    <li><b>Weapon</b>: <?php echo $character['weapon'] ? $character['weapon'] : 'None'; ?></li>
                    <li><b>Armor</b>: <?php echo $character['armor'] ? $character['armor'] : 'None'; ?></li>
                </ul>
            </div>
        </div>
        <div class="right">
            <p>
                <?php echo $character['bio']; ?>
            </p>
        </div>
        <div style="clear: both"></div>
    </div>
</div>
<footer>&copy; Israa 2023</footer>
</body>
</html>
<?php
    } else {
        // Character not found, display error message
        echo "Character not found.";
    }
} else {
    // Character ID not provided in the URL, display error message
    echo "Character ID not provided.";
}
?>
