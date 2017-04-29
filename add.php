<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>Teplomer</title>
    </head>
    <body>
        <?php
             mb_internal_encoding("UTF-8");
function nactiTridu($trida)
{
    require("$trida.php");
}
spl_autoload_register("nactiTridu");

Databaze::pripoj('127.0.0.1', 'pozemstancz001', '224PSOMim7', 'pozemstancz01');
$teplota;
$vlhkost;
$teplota=(int)htmlspecialchars($_GET["teplota"]);
$teplotaVenku=(float)htmlspecialchars($_GET["teplotaVenku"]);
$vlhkost=(int)htmlspecialchars($_GET["vlhkost"]);

if($teplota >0)
{
Databaze::dotaz("
            INSERT INTO `teplomer`
            (`datetime`, `teplota`, `teplotaVenku` , `vlhkost`)
            VALUES (?, ?, ?, ?)",array(date("Y-m-d H:i:s"),$teplota, $teplotaVenku ,$vlhkost));
}
else
{
        echo "Nefunguje to!!! .......teplota: ".$teplota."vlhkost".$vlhkost." ----tu to je!!!!!";}
?>
    </body>
</html>
