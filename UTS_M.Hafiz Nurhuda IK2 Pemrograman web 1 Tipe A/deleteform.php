<?php
include"koneksi.php";
$id=$_GET['id'];
$query="delete from ini_member where member_id='$id'";
mysql_query($query);
header("location:List.php");



?>