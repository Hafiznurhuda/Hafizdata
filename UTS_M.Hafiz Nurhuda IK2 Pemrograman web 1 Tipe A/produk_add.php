<?php
include "koneksi.php";

$nama=$_POST['nama'];
$buton=$_POST['jenis'];
$telpon=$_POST['tel'];
$email=$_POST['email'];
$alamat=$_POST['alamat'];
$bulan=$_POST['tang'];
$cat=$_POST['catat'];
$kota=$_POST['ko'];
$pos=$_POST['cod'];
$produkid = getautoid('member_id','ini_member','mbr');

$query="INSERT INTO `member`.`ini_member` (`member_id`,`nama_lengkap`,`jenis_kelamin`,`tanggal_lahir`,`telepon`,`email`,`alamat`,`catatan`,`kota`,`kode_pos`) VALUES ('$produkid','$nama','$buton','$bulan','$telpon','$email','$alamat','$cat','$kota','$pos')";

mysql_query($query);

header("location:List.php");





?>
