<?php
/**
 * Created by PhpStorm.
 * User: maart
 * Date: 6-4-2017
 * Time: 20:29
 */
$ServerName = "localhost";
$ServerUsername = "root";
$PassWord = "";
$DatabaseName = "db_string";
$database = new PDO('mysql:host=localhost;dbname=db_string',$ServerUsername,$PassWord);
$database->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
