<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Login e Cadastro</title>
</head>
<body>
    
    <div class="lc">
        <div class="frm">
            <h1>Login</h1>
            <form action="login.php" method="post" id="f1">
                <input type="text" name="username" placeholder="Usuário">
                <input type="password" name="password" placeholder="Senha">
            </form>
            <input type="submit" value="Logar" form="f1">
        </div>

        <div class="frm">
            <h1>Cadastro</h1>
            <form action="cadastro.php" method="post" id="f2">
                <input type="text" name="username" placeholder="Usuário">
                <input type="text" name="email" placeholder="Email">
                <input type="text" name="telefone" placeholder="Telefone (xxxx-xxxx)">
                <input type="text" name="cep" placeholder="CEP (xxxxx-xxx)">
                <input type="password" name="password1" placeholder="Senha">
                <input type="password" name="password2" placeholder="Confirme a senha">
            </form>
            <input type="submit" value="Cadastrar" form="f2">
        </div>
    </div>
</body>
</html>