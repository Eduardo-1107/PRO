<?php
$raiz = "../";

// CABECERA
$titulo = "Formulario POST";
include $raiz."shared/header.php";
?>
<form action="respuesta.php" method="post">
    <p>Su nombre: <input type="text" name="nombre" /></p>
    <p>Su edad: <input type="text" name="edad" /></p>
    <p><input type="submit" /></p>
</form>

<?php
// PIE DE PÁGINA
include $raiz."shared/footer.php";
?>
