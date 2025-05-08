<?php
$raiz = "./";

// CABECERA
$titulo = "Listado de ejemplos";
include $raiz."shared/header.php";

$a = 4;
$b = 10;
$suma=$a+$b;
printf("<h1>%s+%s=%s</h1>\n",$a,$b,$suma);

// PIE DE PÁGINA
include $raiz."shared/footer.php";

