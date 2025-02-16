<?php 

session_start();

$n1 = $_POST["n1"]; $n2 = $_POST["n2"]; $o=" ";

if ( isset($_POST["ope"]) ){ $o = $_POST["ope"]; }

try {
    checarOpe($o);
} catch (Exception $e){
    $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n";
    header("Location: mensagem.php"); exit;
}


function checarVazio($n1, $n2){
    if ( $n1=="" || $n2=="" ){ throw new Exception("Não deixe os valores vazios"); }
}
function checarNum($n1, $n2){
    if( !is_numeric($n1) || !is_numeric($n2) ){ throw new Exception("Ambos os valores devem ser números"); }
}
function checarOpe($o){
    if( !str_contains("+-*/l^", $o) || !isset($o) ){ throw new Exception("Operação inválida"); }
}
function div0($n2){
    if( $n2 == 0 ){ throw new Exception("Não é possível dividir por 0"); }
}
function pot00($n1, $n2){
    if( $n1 == 0 && $n2 == 0 ){ throw new Exception("0^0 é indefinido"); }
}
function base0($n1){
    if( $n1 == 0 ){ throw new Exception("O logaritmando deve ser diferente de 0"); }
}
function rad0($n2){
    if( $n2 == 0 ){ throw new Exception("O índice deve ser diferente de 0"); }
}



function som($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);

    return $n1 + $n2;
}
function sub($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);

    return $n1 - $n2;
}
function mul($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);

    return $n1 * $n2;
}
function div($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);
    div0($n2);

    return $n1 / $n2;
}
function pot($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);
    pot00($n1, $n2);

    return $n1 ** $n2;
}
function rad($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);
    rad0($n2);

    return $n1 ** (1/$n2);
}
function lgr($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);
    base0($n2);

    return log($n1, $n2);
}
function pct($n1, $n2){
    global $o;
    checarVazio($n1, $n2);
    checarNum($n1, $n1);
    checarOpe($o);

    return $n1 * $n2 /100;
}


switch ($o){
    case '+': 
        try{ $r = som($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit;
        }
        break;
    case '-': 
        try{ $r = sub($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case '*': 
        try{ $r = mul($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case '/': 
        try{ $r = div($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case '^': 
        try{ $r = pot($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case 'l': 
        try{ $r = lgr($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case '√': 
        try{ $r = rad($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
    case '%': 
        try{ $r = pct($n1,$n2); } 
        catch(Exception $e){ 
            $_SESSION["msg"] = "Erro: ".$e->getMessage().".\n"; 
            header("Location: mensagem.php"); exit; 
        }
        break;
}

$_SESSION["r"] = $r;
header("Location: principal.php");
?>