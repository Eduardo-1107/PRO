<!doctype html>
<html lang="es"
  <head>
    <meta charset="utf-8">
    <title>Ejemplo</title>
  </head>
  <body>
<h3>EJEMPLOS MANIPULACION DE STRING</h3>
<?php
echo "<p>substr('abcdef',-1) = ".substr("abcdef",-1)."</p>";
echo "<p>substr('abcdef',-2) = ".substr("abcdef",-2)."</p>";
echo "<p>substr('abcdef,2) = ".substr("abcdef",2)."</p>";
echo "<p>substr('abcdef',-3,1) = ".substr("abcdef",-3,1)."</p>";

echo "<p>substr('abcdef',0,-1) = ".substr("abcdef",0,-1)."</p>";
echo "<p>substr('abcdef',2,-1) = ".substr("abcdef",2,-1)."</p>";
echo "<p>substr('abcdef',4,-4) = ##".substr("abcdef",4,-4)."##</p>";
echo "<p>substr('abcdef',-3,-1) = ".substr("abcdef",-3,-1)."</p>";
echo "<p>substr('abcdef',-3) = ".substr("abcdef",-3)."</p>";
echo "<p>substr('abcdef',8) = ".substr("abcdef",8)."</p>";
?>
</body>
</html>

