<!DOCTYPE html>
<html>
    <head>
        <title>Ejemplo</title>
    </head>
    <body>
    <?php
        $nFich = 'HojaCalculo.csv';
        if(($arc = fopen($nFich,"r")) == false)
            echo $nFich." no encontrado";
        else{
            while(($linea = fgets($arc))!=false)  {
                if(strlen($linea)!=0){
                    $tab = explode(';',$linea);
                    //echo $linea." <br>";
                    printf("Vendedor: %s / %s(%s):%.2f€<br>\n",$tab[0],$tab[2],$tab[1],$tab[3]);
                }
            }
            fclose($arc);
        }
        ?>
    </body>
</html>