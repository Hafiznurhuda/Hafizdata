<?php
include "koneksi.php";

$id =$_POST['id'];
$name =$_POST['nama'];
$buton=$_POST['jenis'];
$telpon=$_POST['tel'];
$email=$_POST['email'];
$alamat=$_POST['alamat'];
$bulan=$_POST['tang'];
$cat=$_POST['catat'];
$kota=$_POST['ko'];
$pos=$_POST['cod'];

$query="UPDATE ini_member SET nama_lengkap='$name',jenis_kelamin='$buton',tanggal_Lahir='$bulan',telepon='$telpon',email='$email',alamat='$alamat',kota='$kota',kode_pos='$pos',catatan='$cat' WHERE member_id='$id'";
mysql_query($query);
header("location:List.php");
?>

