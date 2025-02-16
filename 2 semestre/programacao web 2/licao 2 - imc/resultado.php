<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>IMC</title>
</head>
<body>
    <div class="topo"><h1>O resultado do seu IMC</h1></div>

    <div class="corpo resultado">
        <?php
            $a = $_POST['altura'];
            $p = $_POST['peso'];
            $r = round( $p / ($a*$a), 2);

            $texto = 
            ($r<16.9 ? 'Muito abaixo do peso' : 
            ($r<18.4 ? 'Abaixo do peso' : 
            ($r<25.0 ? 'Peso normal' : 
            ($r<30.0 ? 'Acima do peso' : 
            ($r<34.9 ? 'Obesidade grau I' : 
            ($r<40.0 ? 'Obesidade grau II' : 'Obesidade grau III') ) ) ) ) );

            echo '
            <h2>Olá '.$_POST['nome'].'! Veja seus resultados!</h2>
            <div id="dados">
                <img src="grafico.png" width="50%">
                <div>
                    <p>Sexo: '.($_POST['sexo'] == "m" ? "Masculino" : "Feminino").'</p>
                    <p>Altura: '.$a.'m</p>
                    <p>Peso: '.$p.'kg</p>
                    <p>Seu IMC é de '.$r.'</p>
                    <h3>'.$texto.'</h3>
                </div>
            </div>';
        ?>
    </div>
</body>
</html>