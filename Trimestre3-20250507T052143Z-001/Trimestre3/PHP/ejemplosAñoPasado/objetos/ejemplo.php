<?php
include_once 'frances.php';
include_once 'persona.php';

$juan = new Persona("Juan Martín",23);
$marie = new Frances("Marie Courie",35);
$jack = new Frances("Jack");

$mod="i";
$patron = sprintf("<%s>* %%s</%s><br>\n",$mod,$mod);
echo $patron;
printf($patron,$juan->saludo());
printf($patron,$marie->saludo());
printf($patron,$jack->saludo());
printf("Nombre: ".$patron,$jack->nombre);
printf($patron,"Nombre: ".$jack->nombre);

printf("**%c**: **%5d**",97,97);