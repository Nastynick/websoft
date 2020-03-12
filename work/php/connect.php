<?php


require "config.php";
require "src/functions.php";

$db = connectDatabase($dsn);

$stmt = $db->prepare("SELECT * FROM tech");
$stmt->execute();


require __DIR__ . "/header.php";

$res = $stmt->fetchAll();

?>

<link href="css/style.css" rel="stylesheet">
<style>
body {
  background-image: url('resources/images/dark-honeycomb.png');
}
</style>
<h1 class="headerText">Search Page</h1>
<table>
    <tr>
        <th>Label</th>
        <th>Type</th>
    </tr>

<?php foreach($res as $row) : ?>
    <tr>
        <td><?= $row["id"] ?></td>
        <td><?= $row["label"] ?></td>
        <td><?= $row["type"] ?></td>
    </tr>
<?php endforeach; ?>

</table>

<?php
require __DIR__ . "/footer.php";
?>