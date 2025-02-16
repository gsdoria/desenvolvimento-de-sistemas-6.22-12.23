<?php session_start();?>
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
            <h1>Operações</h1>

            <form action="conta.php" method="post" id="f2">
                <input type="number" name="n1" placeholder="1º número">
                <input type="number" name="n2" placeholder="2º número">

                <div class="calc">
                    <input type="radio" id="+" name="ope" value="+"><label for="+">+</label>
                    <input type="radio" id="-" name="ope" value="-"><label for="-">-</label>
                    <input type="radio" id="*" name="ope" value="*"><label for="*">*</label>
                    <input type="radio" id="/" name="ope" value="/"><label for="/">/</label>
                    <input type="radio" id="^" name="ope" value="^"><label for="^">^</label>
                    <input type="radio" id="l" name="ope" value="l"><label for="l">log</label>
                </div>
                
                <input type="submit" value="Cadastrar" form="f2">
            </form>
            
        </div>
    </div>

    <div class="rm">
        <p>Guilherme Santana Dória 2DS2 RM: 07287</p>
    </div>
</body>
</html>