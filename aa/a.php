<!DOCTYPE html>
<html>
<?php
error_reporting(false);
 session_start();
?>
<head>
 <title>Tugas 2</title>
</head>
<body>
<div align="center" style="font-family:arial;font-size:30px;">
Program Tambah Data tanpa Database Menggunakan Session</div>
</br>

<form method="post">
 <table>
<tr>
   <td>Masukkan Nama</td>
   <td>: <input type="text" name="nama"></td>
  </tr>
<tr>
   <td>Masukkan Alamat</td>
   <td>: <input type="text" name="alamat"></td>
  </tr>
<tr>
   <td><input type="submit" name="kirim" value="Kirim"></td>
  </tr>
</table>
</form>
<?php
 // Ambil data dari session
 if (isset($_SESSION['tmpnama'])) {
  $tmpnama = $_SESSION['tmpnama'];
 }
 if (isset($_SESSION['tmpalamat'])) {
  $tmpalamat = $_SESSION['tmpalamat'];
 }
 // End ambil data dari session

 // Tambahkan array (hasil dari data session tadi) dengan data inputan yang baru
 $tmpnama[] = $_POST['nama'];
 $tmpalamat[] = $_POST['alamat'];
 // End script tambah ke array

 // Simpan data array yang baru ke session
 $_SESSION['tmpnama'] = $tmpnama;
 $_SESSION['tmpalamat'] = $tmpalamat;
 // End script simpan ke session
?>
<br>
<table>
<tr>
  <td>No.</td>
  <td>Nama</td>
  <td>Alamat</td>
 </tr>
<?php
   // Ambil data dari session
   if (isset($_SESSION['tmpnama'])) {
    $tmpnama = $_SESSION['tmpnama'];
   }
   if (isset($_SESSION['tmpalamat'])) {
    $tmpalamat = $_SESSION['tmpalamat'];
   }
   // End script ambil data

   // Cetak dengan cara uraikan isi arraynya
   for ($i=0; $i < count($tmpnama); $i++) { 
    echo "<tr><td>"; echo $i."</td><td>".$tmpnama[$i]."</td><td>".$tmpalamat[$i]."</td></tr>
";
   }
   // End script urai array
  
  ?>
</table>
<script type="text/javascript">
  function submitForm(action) {
    var form = document.getElementById('form1');
    form.action = action;
    form.submit();
  }
</script>

...

<form id="form1">
  <!-- ... -->
  <input type="button" onclick="submitForm('page1.php')" value="submit 1" />
  <input type="button" onclick="submitForm('page2.php')" value="clear" />
</form>
</body>
</html>
