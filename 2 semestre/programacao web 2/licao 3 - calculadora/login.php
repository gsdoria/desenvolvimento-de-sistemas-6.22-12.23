<?php 

session_start(); $_SESSION = $_POST; $_SESSION['login'] = 0;

if( $_SESSION['senha'] == 123 ){ $_SESSION['login'] = 1; header('Location: calculadora.php'); }

else{ header('Location: index.php'); }

?>