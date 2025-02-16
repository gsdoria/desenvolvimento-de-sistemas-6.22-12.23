<?php session_start(); if(!isset($_SESSION['username'])){ header('Location: index.php'); exit; } ?>
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
        <h1>Bem vindo, <?php echo $_SESSION['username']; ?>!</h1>
        <h2>Lista de todos os usuários: </h2>
        <div class="lista">
            <ol>
            <?php 
                $file = fopen('lote.csv', 'r');
                while ( ( $row = fgetcsv($file) ) != false ){ echo "<li>".$row[0]."</li>"; }
            ?>
            </ol>
        </div>

        <button onclick="location.href='logout.php'" type="button">Sair</button>
    </div>
</body>
</html>