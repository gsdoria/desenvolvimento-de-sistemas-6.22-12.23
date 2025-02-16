<?php session_start(); $_SESSION['mensagem']="";
if($_SERVER['REQUEST_METHOD']==='POST'){  
    if(empty($_POST['username'])||empty($_POST['password'])){        
        $_SESSION['mensagem'] = "Preencha o nome de usuário e a senha."; header('Location: mensagem.php'); exit;
    }

    $username = $_POST['username']; $password = $_POST['password'];

    $file = fopen('lote.csv', 'r');
    if(!$file){ $_SESSION['mensagem'] = "Arquivo inexistente."; header('Location: mensagem.php'); exit; }

    $found=false;
    while (($row=fgetcsv($file)) != false){
        if($row[0] == $username && password_verify($password,$row[1])){ $found=true; break; }
    }
    fclose($file);

    if ($found){ $_SESSION['username'] = $username; header('Location: principal.php'); }
    else { $_SESSION['mensagem'] = 'Usuário ou senha inexistente.'; header('Location: mensagem.php'); }
}
?>