<?php
include "koneksi.php";
error_reporting(false);
 session_start();
$id = getautoid('pengirimanid','pengiriman_header`','PRD');
$sip= $_POST['sip'];
$harga 		= $_POST['origin'];
$qty 		= $_POST['dest'];
$rear 		=$_POST['fi'];

if ($_POST['pesan'] == 'add record') 
{

  
}
else if ($_POST['pros'] == 'Process') 
{

$query = "INSERT INTO `pengiriman_header` 
	(`pengirimanid`,`requesttype`,`portorigin`,`weight`) 
	VALUES ('$id','$sip','$harga','$tmpama')";

		
mysql_query($query);

$querya = "INSERT INTO `pengiriman_detail` 
	(`id`,`itemdesc`,`qty`,`satuan`,`goodcategory`) 
	VALUES ('1','$rear','$tmpalamat[$i]','$satuan[$i]','$gd[$i]')";
mysql_query($querya);
}


for ($i=""; $i < count($tmpnama); $i++) 
?>

<form method="POST" action="">
<input type="input" value="<?php echo $_GET['desc'];?>">wwdwds