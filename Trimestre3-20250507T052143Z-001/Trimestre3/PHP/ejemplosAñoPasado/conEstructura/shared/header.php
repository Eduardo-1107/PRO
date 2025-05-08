<!doctype html>
<html lang="es"
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="<?php echo $raiz;?>/wwwroot/css/styles.css">
    <title><?php echo $titulo ?></title>
  </head>
  <body>
    <header>
        <hr/>
        <h2>Ejemplos PHP</h2>
        <h3><?php echo $titulo ?></h3>
        
        <ul class="menu">
        <?php
        $menu = [
          $raiz => "Inicio",
          $raiz."ejemplo1.php" => "Ejemplo 1",
          $raiz."session/contadorSession.php" => "Contador",
          $raiz."formularioGet/formulario.php" => "Ejemplo GET",
          $raiz."formularioPost/formulario.php" => "Ejemplo POST",
          $raiz."DelEjercicio6/Digitos.php" => "Imágenes de números"
        ];
        foreach($menu as $linkOp => $op)
          echo "<li><a href=\"$linkOp\">$op</a></li> "
        ?>
        </ul>
        <hr/>
    </header>
    <main>