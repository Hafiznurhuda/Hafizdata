<?php
include "koneksi.php";
error_reporting(false);
 session_start();
$id = getautoid('pengirimanid','pengiriman_header`','PRD');
$sip= $_POST['sip'];
$ori 		= $_POST['origin'];
$des 		= $_POST['dest'];
$ship		= $_POST['shipmen'];
$wer		= $_POST['wei'];
$dm			= $_POST['dim'];

$rear 		=$_POST['fi'];

if ($_POST['pesan'] == 'add record') 
{

  
}
else if ($_POST['pros'] == 'Process') 
{

$query = "INSERT INTO `pengiriman_header` 
	(`pengirimanid`,`requesttype`,`portorigin`,`requestby`,`requestdate`,`portdestination`,`shipmenmode`,`weight`,`dimension`) 
	VALUES ('$id','$sip','$ori','Amanda','2018-12-27','$des','$ship','$wer','$dm')";

		
mysql_query($query);
$i =$_POST['fdd'];
 $ff =$_POST['fi'];
   $fl =$_POST['fl'];
   $fk =$_POST['fk'];
   $fg =$_POST['fg'];
   
  $query = "INSERT INTO `pengiriman_detail` 
	(`id`,`itemdesc`,`qty`,`satuan`,`goodcategory`) 
	VALUES ('$i','$ff','$fl','$fk','$fg')";

		
   mysql_query($query);
}

header("location:nen.php")

?>
