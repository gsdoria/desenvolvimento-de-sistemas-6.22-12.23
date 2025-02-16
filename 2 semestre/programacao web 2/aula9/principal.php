<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>
<body>

    <div class="pri">
        <h1>O resultado é: </h1>
        <?php echo "<h1>".$_SESSION["r"]."</h1>"; ?>
        <button onclick="location.href='index.php'" type="button">Voltar</button>
    </div>
    <div class="rm">
        <p>Guilherme Santana Dória 2DS2 RM: 07287</p>
    </div>
</body>
</html>