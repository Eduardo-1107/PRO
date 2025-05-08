<?php
$raiz = "../";

// CABECERA
$titulo = "Formulario POST";
include $raiz."shared/header.php";
?>
<h3>
    Hola
    <?php echo htmlspecialchars($_POST['nombre']); ?>.
</h3>
<h3>
    Usted tiene
    <?php echo (int) $_POST['edad']; ?> años.
</h3>
<?php
// PIE DE PÁGINA
include $raiz."shared/footer.php";
?>
