<?php
$titulo = "Ejemplo "."1";

$a = 12;
$b = -4;
$suma = $a + $b ;
printf("<p>%d</p>\n", $a);
$s = sprintf("<p>%d</p>", $b);
echo $s;

printf("<p>%d + %d = %d</p>\n", $a,$b,$suma);
echo "<p><b>$a + $b = $suma</b></p>";
echo '<p><b>$a + $b = $suma</b></p>';

$entrada = "hola,qué tal";
$t =  explode( ',', $entrada );
foreach($t as $v)
    echo "\n<p>$v</p>";
