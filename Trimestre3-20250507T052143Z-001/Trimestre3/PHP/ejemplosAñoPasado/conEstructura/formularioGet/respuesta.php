<?php
$raiz = "../";

// CABECERA
$titulo = "Formulario GET";
include $raiz."shared/header.php";
?>
<h3>
    Hola
    <?php echo htmlspecialchars($_GET['nombre']); ?>.
</h3>
<p>Usted sometimes lleva jugando <b>tenis</b> 
    <?php echo (int) $_GET['edad']; ?> años.
</p>
    
<?php
// PIE DE PÁGINA
include $raiz."shared/footer.php";
?>
