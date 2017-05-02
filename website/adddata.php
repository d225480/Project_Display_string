<?php
/**
 * Created by PhpStorm.
 * User: maart
 * Date: 2-5-2017
 * Time: 15:45
 */
include "database.php";
$text = $_POST['text'];
$testsql = "INSERT INTO string (text) VALUES ('$text')";
$sql = "UPDATE string SET text='$text' WHERE ID = 1 ";
$database->query($sql);
header("Location:index.php");