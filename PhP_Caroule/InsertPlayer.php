<?php
    //Variable for the connection
    $servername = "localhost";
    $server_username = "id1388754_pwet";
    $server_password = "123456";
    $dbName = "id1388754_caroule";

    //Variable from the user
    $username = $_POST["usernamePost"];
    $password = $_POST["passwordPost"];
    $highscore = $_POST["highscorePost"];
    $hashpass = hash('sha256', $password);
    //Make connection 
    $conn = new mysqli($servername, $server_username, $server_password, $dbName);

    //check connection
    if(!$conn){
        die("Connection Failed.". mysqli_connect_error());
    }

    $sql = "SELECT HighScore FROM players WHERE Player = '".$username."'";
    $result = mysqli_query($conn , $sql);

    if(mysqli_num_rows($result) > 0) {
        //show data for each row
        while($row = mysqli_fetch_assoc($result)){
            if (((int)$row['HighScore']) < ((int)$highscore)) {
                $sql = "UPDATE players SET HighScore = '".$highscore."' WHERE Player = '".$username."'";
                $result = mysqli_query($conn , $sql);
                if(!$result) echo "HighScore_nOk";
                else echo $highscore;
                break;
            }
            else {
                echo $row['HighScore'];
            }
        }
    }
    //$sql = "INSERT INTO players (Player, Password, HighScore) VALUES ('".$username."', '".$password."', '".$highscore."')";
    
?>