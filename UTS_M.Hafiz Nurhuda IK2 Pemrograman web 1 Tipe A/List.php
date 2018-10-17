<?php include "koneksi.php";?>
<div class="container">
  <center><h2>Ini Tabel</h2>
  <p>Cintailah Ploduk-ploduk Indonesia</p>                                                                                      
         </center>
  <table width=85% border="3" align="center">
    <thead>
      <tr>
        <th >No</th>
        <th>nama lengkap</th>
		<th>Telepon</th>
        <th>E-mail</th>
        <th>Alamat</th>
		<th>Aksi kita </th>
      </tr>
    </thead>
    <tbody>
	
	<?php 
	$query = "select * from ini_member";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td align="center"><?php echo $row['member_id'];?></td>
        <td align="center"><?php echo $row['nama_lengkap'];?> </td>
        <td align="center"><?php echo $row['telepon'];?></td>
        <td align="center"><?php echo $row['email'];?></td>
		<td align="center"><?php echo $row['alamat'];?></td>
        <td align="center"><a href="edit.php?mod=produk_form&id=<?php echo $row['member_id'];?>"> edit</a> |<a href="deleteform.php?mod=produk_form &id=<?php echo $row['member_id'];?>"> delete</a></td>
      </tr>
	<?php } ?>
	
	
    </tbody>
  </table><br><center>
  <button><a href="index.php">back</a></button>  </center>
  </div>
</div>