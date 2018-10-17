
<?php 
include"koneksi.php";
	if(isset($_GET['id'])){
	$id = $_GET['id'];
	
	$query = "select * from ini_member where member_id='".$id."'";
	$row = mysql_query($query);
	$res = mysql_fetch_array($row);
	$nama_lengkap = $res['nama_lengkap'];
	$jenis=$res['jenis_kelamin'];
	$tel=$res['telepon'];
	$tang=$res['tanggal_lahir'];
	$email=$res['email'];
	$alamat=$res['alamat'];
	$kota=$res['kota'];
	$kode=$res['kode_pos'];
	$catat=$res['catatan'];
	
	


	?>


<form method="POST" action="update.php" enctype="multipart/form-data"   >
		
      <p>Nama Lengkap 
	  <input type="hidden" name="id" value="<?php echo $id;?>" >
	  <input type="text" class="form-control"  name="nama" size="30" value="<?php echo $nama_lengkap;?>" >
	  </p>
  <tr> <p>Jenis Kelamin &nbsp;&nbsp; <input type="radio" class="form-control" name="jenis" value="pria" <?php if($jenis=='pria') echo 'checked'; ?>/> Pria <input type="radio" class="form-control"  name="jenis"  value="wanita"<?php if($jenis=='wanita') echo 'checked'; ?>> Wanita</p>
        
	</tr>
	<p>tanggal <input type="date" name="tang" value="<?php echo $tang;?>">
	<td><p>telpon <input type="number" name="tel" value="<?php echo $tel; ?>"></p></p></td></input>
	
<td><p>Email<input type="text" class="form-control"  "  name="email" size="30"value="<?php echo $email; ?>" ></p></td>
	
	
	<table>
	<tr>
	<td>Alamat</td>
              <td>:</td>
              <td><input type="textarea"name="alamat" cols="30" rows="5" id="alamat" value="<?php echo $alamat;?>"></input></td>
           
			</tr>
			
		 </table>	
		 <p>Kota <input type="text" name="ko" value="<?php echo $kota; ?>"></p>
	     <p>Kode Pos <input type="text" name="cod" value="<?php echo $kode; ?>"></p>
<p>catatan <input type="text" class="form-control"   name="catat" size="30" value="<?php echo $catat; ?>" ></p>
	
	
	
<table  >
<tr ><td >
<button type="submit" class="btn btn-outline-primary" >Update</button>&nbsp;&nbsp;&nbsp;&nbsp;<button> <a href="List.php">batal</a></button></tr></td>
	

	<?php } ?>
  </form>

 </table>
 
 