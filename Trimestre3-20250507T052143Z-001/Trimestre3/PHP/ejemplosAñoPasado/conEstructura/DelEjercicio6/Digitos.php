<?php
$raiz = "../";

// CABECERA
$titulo = "Imágenes de números";
include $raiz."shared/header.php";
?>
<ul>
<li><a href="Digitos.php?num=0">0</a></li>
<li><a href="Digitos.php?num=1">1</a></li>
<li><a href="Digitos.php?num=2">2</a></li>
<li><a href="Digitos.php?num=3">3</a></li>
<li><a href="Digitos.php?num=4">4</a></li>
<li><a href="Digitos.php?num=5">5</a></li>
</ul>
<?php
    if(isset($_GET['num']))
        printf("<img src='Imagenes/%s.png' alt='numero %s' width='50' height='60'/>",$_GET['num'],$_GET['num']);
?>


<?php
// PIE DE PÁGINA
include $raiz."shared/footer.php";
?>
