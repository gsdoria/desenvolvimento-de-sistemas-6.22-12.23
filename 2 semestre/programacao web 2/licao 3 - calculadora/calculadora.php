<?php session_start();?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Calculadora</title>
</head>
<body>
    <?php

        if( $_SESSION['login'] == 1 ){
            echo '
                <form action="resultado.php" method="post">
                    <div class="container">
                        <h1>Olá '.$_SESSION['nome'].'! Bem vindo a calculadora!</h1>

                        <label for="n1">Número 1: </label>
                        <input type="number" name="n1"><br>

                        <label for="n2">Número 2: </label>
                        <input type="number" name="n2"><br>

                        <p>
                            <input type="radio" id="+" name="ope" value="+"><label for="+">+</label>
                            <input type="radio" id="-" name="ope" value="-"><label for="-">-</label>
                            <input type="radio" id="*" name="ope" value="*"><label for="*">*</label>
                            <input type="radio" id="/" name="ope" value="/"><label for="/">/</label>
                            <input type="radio" id="^" name="ope" value="^"><label for="^">^</label>
                            <input type="radio" id="l" name="ope" value="log"><label for="l">log</label>
                        </p>

                        <input type="submit" value="Enviar">
                    </div>
                </form>';
        }
        else { header('Location: index.php'); }

    ?>

    <footer>© 2023 - <?php echo date('Y') ?></footer>

</body>
</html>