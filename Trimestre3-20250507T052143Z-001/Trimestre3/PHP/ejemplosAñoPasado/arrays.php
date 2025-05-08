<!doctype html>
<html lang="es"
  <head>
    <meta charset="utf-8">
    <title>Ejemplo</title>
  </head>
  <body>

  <h2>Un Array</h2>
    <ul>
<?php
$PrimerSemestre = array("uno" => 'Enero', 'Febrero', 'Marzo', 20 => 'Abril','Mayo','Junio');
print_r($PrimerSemestre);
echo "<br/>Tamaño: ".count($PrimerSemestre);
?>
</ul>
<hr/>


<h2>Array (sintaxis breve)</h2>
<ul>
<?php
 $a = [1, 2, 3, 4];
 print_r($a);
 for($i=0;$i<count($a);$i++)
    print "<br>$a[$i]";
 echo "<br/>";
 $a = ['one' => 1, 'two' => 2, 'three' => 3, 'four' => 4];
 print_r($a);
 foreach($a as $v)
   print "<br>$v";
 foreach($a as $k=>$v)
   print "<br>$k es $v";
 ?>
</ul>
<hr/>


<h2>Array bidimensional</h2>
    <ul>
<?php
$fruits = array (
  "frutas"  => array("a" => "naranja", "b" => "plátano", "c" => "manzana"),
  "números" => [1, 2, 3, 4, 5, 6],    // array(1, 2, 3, 4, 5, 6),
  "hoyos"   => array("primero", 5 => "segundo", "tercero")
);
echo "Filas: ".count($fruits);
foreach($fruits as $fila){
  echo "<li><ul>\n";
  foreach($fila as $k => $v){
    echo "<li>$k -> $v</li>\n";
  }
  echo "<li>Tamaño: ".count($fila)."</li><br/>";
  echo "</ul></li>\n";
}
print_r($fruits)
?>
</ul>
  
</body>
</html>

