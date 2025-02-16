<?php session_start(); $_SESSION['mensagem'] = "";

if (!filter_var($_POST['email'], FILTER_VALIDATE_EMAIL)) {
    $_SESSION['mensagem'] = "O endereço de e-mail não é válido"; header('Location: mensagem.php'); exit;
}

if (!preg_match("/^[0-9]{4}-[0-9]{4}$/", $_POST['telefone'])) {
   $_SESSION['mensagem'] = "O número de telefone não é válido"; header('Location: mensagem.php'); exit;
}

if (!preg_match("/^[0-9]{5}-[0-9]{3}$/", $_POST['cep'])) {
   $_SESSION['mensagem'] = "CEP inválido."; header('Location: mensagem.php'); exit;
}

if($_POST['password1'] !== $_POST['password2']){    
    $_SESSION['mensagem'] = "A senhas não são as mesmas!"; header('Location: mensagem.php'); exit;
}

if (strlen($_POST['password1']) < 8) {
   $_SESSION['mensagem'] = "A senha deve ter pelo menos 8 caracteres"; header('Location: mensagem.php'); exit;
}

$login = [ ['login'=>$_POST['username'], 'senha'=>password_hash($_POST['password1'], PASSWORD_DEFAULT)] ];

$file = fopen('lote.csv', 'r'); $found = false;
while (($row = fgetcsv($file)) != false){
   if($row[0] == $_POST["username"] && password_verify($_POST["password1"],$row[1])){ $found = true; break; } } 
fclose($file);

if(!$found){
   $arquivo = fopen('lote.csv','a');
   foreach($login as $linha){ fputcsv($arquivo, $linha); } fclose($arquivo);

   $_SESSION['mensagem'] = "Cadastro realizado com sucesso!"; header('Location: mensagem.php'); exit;

} else { $_SESSION["mensagem"] = "Conta já existente."; header('Location: mensagem.php'); exit; }
?>