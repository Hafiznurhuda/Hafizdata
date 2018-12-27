<?php
include "koneksi.php";

session_start();
session_destroy();

$id = getautoid('pengirimanid','pengiriman_header`','PRD');
$sip= $_POST['sip'];
$harga 		= $_POST['origin'];
$qty 		= $_POST['dest'];




$query = "INSERT INTO `pengiriman_header` 
	(`pengirimanid`,`requesttype`,`portorigin`) 
	VALUES ('$id','$sip','$harga')";

		
mysql_query($query);

//header("location:../index.php?mod=produk_form");







