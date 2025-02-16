<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>IMC</title>
</head>
<body>
    <div class="topo"><h1>Faça o seu IMC</h1></div>

    <div class="corpo">
        <form name="resultado" action="resultado.php" method="post">
            <label for="nome"></label><input type="text" name="nome" placeholder="Seu nome:"><br>

            <label for="altura"></label><input type="number" name="altura" placeholder="Sua altura (em m):" step="0.01"><br>

            <label for="peso"></label><input type="number" name="peso" placeholder="Seu peso (em kg):" step="0.01"><br>

            <input type="radio" id="m" name="sexo" value="m"><label for="m">masculino</label>

            <input type="radio" id="f" name="sexo" value="f"><label for="f">feminino</label><br>

            <input type="submit" value='enviar'>
        </form>
    </div>
</body>
</html>