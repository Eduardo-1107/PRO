<?php
$raiz = "../";

// CABECERA
$titulo = "CONTADOR (Con variable de Sesión)";
include $raiz."shared/header.php";
?>

<h2>Ejemplo Contador (variable de sesión)</h2>
<hr/>
<?php
session_start();
if(!isset($_SESSION["conteo"]))
    $_SESSION["conteo"]=0;
else
    if(isset($_GET["cont"]) && $_GET["cont"]=="si")
        $_SESSION["conteo"] += 1;
    else
        $_SESSION["conteo"] = 0;
echo "<h1>". $_SESSION["conteo"]."</h1>";
?>
<a href="contadorSession.php?cont=si">Contar</a><br/>
<a href="contadorSession.php?cont=0">Empezar de cero</a>

<?php
// PIE DE PÁGINA
include $raiz."shared/footer.php";
?>
