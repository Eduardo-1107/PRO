<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio</title>
</head>
<body>
    <table border="1" cellpadding="5" cellpadding="0">
        <tr>
            <th>Operación</th>
            <th>Resultado</th>
        </tr>
        <?php

        for ($i=0; $i <= 10; $i++) { 
            $r = $i*5;
            echo "<tr><td>5 x $i</td> <td>$r</td></tr>";
        }
        ?>




    </table>
</body>
</html>






