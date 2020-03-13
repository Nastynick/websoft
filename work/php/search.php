<?php
require __DIR__ . "/header.php";
?>

<head>
<link href="css/style.css" rel="stylesheet">
<style>
body {
  background-image: url('resources/images/dark-honeycomb.png');
}
</style>
</head>

<body>
<h1> <br></h1>
<form action="connect.php" method="get">
          Label: <input type="text" name="inputSearch" value="">
          <input type="submit">
      </form>

 </body>


<?php
require __DIR__ . "/footer.php";
?>