<?php session_start(); $_SESSION = $_POST; ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Login</title>
</head>
<body>

    <form action='login.php' method='post'>
        <div class="container">
            <label for='nome'>Nome: </label>
            <input type='text' name='nome'>
            
            <br>

            <label for='senha'>Senha: </label>
            <input type='password' name='senha' placeholder='123'>

            <br>

            <input type='submit' value='Enviar'>
        </div>
    </form>

    <footer>© 2023 - <?php echo date('Y') ?></footer>
    
</body>
</html>