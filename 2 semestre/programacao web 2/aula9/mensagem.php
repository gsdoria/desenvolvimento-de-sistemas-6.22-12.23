<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>ERRO</title>
</head>
<body>
    <div class="msg">
        <?php echo "<h2>".$_SESSION['msg']."</h2>" ?>
        <button onclick="location.href='index.php'" type="button">Voltar</button>
    </div>
    <div class="rm">
        <p>Guilherme Santana Dória 2DS2 RM: 07287</p>
    </div>
</body>
</html>