<?php
include "koneksi.php";

session_start();
session_destroy();

?>

<table width="100" border="5">

<tr>
<td>No</td>
<td>Request Name</td>
<td>Request Date</td>
<td>Requrst Type</td>
<td>Port Origin</td>
<td>Port Destination</td>
<td>Weight(KG)</td>
<td>Dimension (CM)</td>
</tr>



<?php 
	$query = "select * from pengiriman_header";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row['requestby'];?></td>
		<td><?php echo $row['requestdate'];?></td>
		<td><?php echo $row['requesttype'];?></td>
		<td><?php echo $row['portorigin'];?></td>
		<td><?php echo $row['portdestination'];?></td>
		<td><?php echo $row['weight'];?></td>
		<td><?php echo $row['dimension'];?></td>
</tr>

	<?php $no++;}?>
	
</table>
<form action="index.html">
  <!-- ... -->
  
  <input type="submit"value="back" >
</form>