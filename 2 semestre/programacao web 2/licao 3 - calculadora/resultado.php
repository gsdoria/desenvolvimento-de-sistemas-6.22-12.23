<?php session_start(); $_SESSION=$_POST; $_SESSION['login']=1 ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Resultado</title>
</head>
<body>

    <?php 

        $n1 = $_SESSION['n1'];
        $n2 = $_SESSION['n2'];
        
        switch ($_SESSION['ope']){
            case '+': $r = $n1+$n2; break;
            case '-': $r = $n1-$n2; break;
            case '*': $r = $n1*$n2; break;
            case '/': $r = $n1/$n2; break;
            case '^': $r = $n1**$n2; break;
            case 'log': $r = log($n2,$n1); break;            
        }

        if($_SESSION['ope']!='log') $t = $n1.' '.$_SESSION['ope'].' '.$n2.' = '.$r;
        
        else $t = 'log<sub>'.$n1.'</sub>'.$n2.' = '.$r;

        echo '
            <div class="container" style="max-width: 40%;">
                <p>'.$t.'</p>
                <a href="index.php"><button>voltar</button></a>
            </div>
        '
    ?>
    
    <footer>© 2023 - <?php echo date('Y') ?></footer>
</body>
</html>