<?php
    $servername = "localhost";
    $username = "id1388754_pwet";
    $password = "123456";
    $dbName = "id1388754_caroule";

    //Make connection 
    $conn = new mysqli($servername, $username, $password, $dbName);

    //check connection
    if(!$conn){
        die("Connection Failed.". mysql_connect_error());
    }

    $sql = "SELECT ID, Player, Password, HighScore FROM players ORDER BY HighScore DESC LIMIT 5";
    $result = mysqli_query($conn , $sql);

    if(mysqli_num_rows($result) > 0) {
        //show data for each row
        while($row = mysqli_fetch_assoc($result)){
            echo "ID:".$row['ID'] . "|Player:".$row['Player']. "|HighScore:".$row['HighScore'].";";
        }
    }
    else echo("Connection Success");
?>