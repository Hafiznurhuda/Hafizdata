<?php
include "koneksi.php";

error_reporting(false);
 session_start();

?>

<html>
<head>

<link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:300' rel='stylesheet' type='text/css'>
<style type="text/css">
body{
	background-image: url('images/sss.jpg');
	
}
.form-style-8{
	font-family: 'Open Sans Condensed', arial, sans;
	width: 500px;
	padding: 30px;
	background: #FFFFFF;
	margin: 50px auto;
	box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.22);
	-moz-box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.22);
	-webkit-box-shadow:  0px 0px 15px rgba(0, 0, 0, 0.22);

}
.form-style-8 h2{
	background: #1e90ff;
	
	text-transform: uppercase;
	font-family:  Lucida Handwriting;
	color: white;
	font-size: 18px;
	font-weight: 100;
	padding: 20px;
	margin: -30px -30px 30px -30px;
}
.form-style-8 input[type="text"],
.form-style-8 input[type="date"],
.form-style-8 input[type="datetime"],
.form-style-8 input[type="email"],
.form-style-8 input[type="number"],
.form-style-8 input[type="search"],
.form-style-8 input[type="time"],
.form-style-8 input[type="url"],
.form-style-8 input[type="password"],
.form-style-8 textarea,
.form-style-8 select 
{
	box-sizing: border-box;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	outline: none;
	display: block;
	width: 100%;
	padding: 7px;
	border: none;
	border-bottom: 1px solid #ddd;
	background: transparent;
	margin-bottom: 10px;
	font: 16px Arial, Helvetica, sans-serif;
	height: 45px;
}
.form-style-8 textarea{
	resize:none;
	overflow: hidden;
}
.form-style-8 input[type="button"], 
.form-style-8 input[type="submit"]{
	-moz-box-shadow: inset 0px 1px 0px 0px #45D6D6;
	-webkit-box-shadow: inset 0px 1px 0px 0px #45D6D6;
	box-shadow: inset 0px 1px 0px 0px #45D6D6;
	background-color: #2CBBBB;
	border: 1px solid #27A0A0;
	display: inline-block;
	cursor: pointer;
	color: #FFFFFF;
	font-family: 'Open Sans Condensed', sans-serif;
	font-size: 14px;
	padding: 8px 18px;
	text-decoration: none;
	text-transform: uppercase;
}
.form-style-8 input[type="button"]:hover, 
.form-style-8 input[type="submit"]:hover {
	background:linear-gradient(to bottom, #34CACA 5%, #30C9C9 100%);
	background-color:#34CACA;
}

</style>
<script type="text/javascript">
//auto expand textarea
function adjust_textarea(h) {
    h.style.height = "20px";
    h.style.height = (h.scrollHeight)+"px";
}
</script>
</head>
<body  >

<div class="form-style-8">
 <h2><b><center><i> Welcome</b></i></h2></center>
  <form method="POST" action="cek.php">
    <h3>Request Type :<select name="sip">
	
<option value="Import">Import</option>
<option value="Export">Export</option>
<option value="Internal Distribution">Internal Distribution</option>

</select></h3>
   <h3> Port Origin :<select name="origin">
    <option></option>
    <?php
    
    $sql = mysql_query("SELECT * FROM port_list");
    if(mysql_num_rows($sql) != 0){
        while($data = mysql_fetch_assoc($sql)){
            echo '<option>'.$data['port_country'].' - '.$data['port_name'].'</option>';
        }
    }
    ?>
</select></h3>
    <h3> Port Destination :<select name="dest">
    <option></option>
    <?php
    
    $sql = mysql_query("SELECT * FROM port_list");
    if(mysql_num_rows($sql) != 0){
        while($data = mysql_fetch_assoc($sql)){
            echo '<option>'.$data['port_country'].' - '.$data['port_name'].'</option>';
        }
    }
    ?>
</select></h3>
    
	<h3>Shipment Mode :<select name="shipmen">
	<option></option>
<option value="Land">Land</option>
<option value="Air">Air</option>
<option value="Sea">Sea</option>

</select></h3><h3>Weight (KG) :
<input type="number" name="wei"></h3>
    <h3>Dimension (CM) :
	<input type="number" name="dim"></h3>
<input type="submit"   name="pros" value="Process">
	</form>
	<form method="POST" action="">
	<h3>	
<table width=104%>
<tr>
<td>Item Description<input type="text" name="desc"></td>
<td>QTY<input type="number" name="qty"></td>
<td>Satuan<input type="text" name="satuan"></td>
<td>GoodCategory<select name="gd">
	<option></option>
<option value="Non DG">Non DG</option>
<option value="DG">DG</option>

</select></td>
<td></td>
</tr>
</table>	

<input type="submit" name="pesan" value="add record"> 
   
   
  
  
  

  <?php
  
  $ite =$_POST['desc'];
  $lite =$_POST['qty'];
  $sat  =$_POST['satuan'];
  $gg	=$_POST['gd'];
  $id = getautoid('id','pengiriman_detail','PRD');
 // Ambil data dari session
 if (isset($_SESSION['tmpnama'])) {
  $tmpnama = $_SESSION['tmpnama'];
 }
 if (isset($_SESSION['tmpalamat'])) {
  $tmpalamat = $_SESSION['tmpalamat'];
 }
  if (isset($_SESSION['satuan'])) {
  $satuan = $_SESSION['satuan'];
 }
  if (isset($_SESSION['gd'])) {
  $gd = $_SESSION['gd'];
 }
 // End ambil data dari session

 // Tambahkan array (hasil dari data session tadi) dengan data inputan yang baru
 $tmpnama[] = $_POST['desc'];
 $tmpalamat[] = $_POST['qty'];
 $satuan[] =$_POST['satuan'];
 $gd[] = $_POST['gd'];
 // End script tambah ke array

 // Simpan data array yang baru ke session
 $_SESSION['tmpnama'] = $tmpnama;
 $_SESSION['tmpalamat'] = $tmpalamat;
 $_SESSION['satuan'] = $satuan;
 $_SESSION['gd'] = $gd;
 // End script simpan ke session
?>

<table width=100% border=2 align="center">
<tr>
  <td>No</td>
  <td>item description</td>
  <td>QTY</td>
  <td>satuan</td>
  <td>good category</td>
 </tr>
<?php
   // Ambil data dari session
   if (isset($_SESSION['tmpnama'])) {
    $tmpnama = $_SESSION['tmpnama'];
   }
   if (isset($_SESSION['tmpalamat'])) {
    $tmpalamat = $_SESSION['tmpalamat'];
   }
   if (isset($_SESSION['satuan'])) {
    $satuan = $_SESSION['satuan'];
   }
   if (isset($_SESSION['gd'])) {
    $gd = $_SESSION['gd'];
   }
   // End script ambil data

   // Cetak dengan cara uraikan isi arraynya
   for ($i=""; $i < count($tmpnama); $i++) { 
    echo "<tr><td>"; echo $i."</td><td>".$tmpnama[$i]."</td><td>".$tmpalamat[$i]."</td><td>".$satuan[$i]."</td><td>".$gd[$i]."</td></tr>
";
   
   // End script urai array
   
  
  ?>
</table>
<input type="text" name="fdd" value="<?php $i;?>">
<input type="text" name="fi"value="<?php echo $ite;?>">
<input type="text" name="fl"value="<?php echo $lite;?>">
<input type="text" name="fk"value="<?php echo $sat;?>">
<input type="text" name="fg"value="<?php echo $gg;?>">
   <?php }?>
</form>
<br>
<script type="text/javascript">
  function submitForm(action) {
    var form = document.getElementById('form1');
    form.action = action;
    form.submit();
  }
</script>

<form id="form1">
  <!-- ... -->
  
  <input type="button" onclick="submitForm('page2.php')" value="clear" >
</form>
</body>
</html>

  </div>




</body>
</html>