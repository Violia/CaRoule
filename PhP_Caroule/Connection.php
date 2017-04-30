<?php
    $servername = "localhost";
    $username = "id1388754_pwet";
    $password = "123456";
    $dbName = "id1388754_caroule";
    $accountOK = "";

    //Variable from the user
    $post_username = $_POST["usernamePost"];
    $post_password = $_POST["passwordPost"];
    $hashpass = hash('sha256', $post_password);
    
    //Make connection 
    $conn = new mysqli($servername, $username, $password, $dbName);

    //check connection
    if(!$conn){
        die("Connection Failed.". mysql_connect_error());
    }

    $sql = "SELECT Player, Password FROM players WHERE Player = '".$post_username."'";
    $result = mysqli_query($conn , $sql);

    if(mysqli_num_rows($result) > 0) {
        //show data for each row
        while($row = mysqli_fetch_assoc($result)){
            if ($row['Password'] == $hashpass) {
                $accountOK = "Connection_Ok";
                break;
            }
            else {
                $accountOK = "Connection_nOk";
            }
        }
        echo $accountOK;
    }
    else {
        $sql = "INSERT INTO players (Player, Password) VALUES ('".$post_username."', '".$hashpass."')";
        $result = mysqli_query($conn , $sql);
        
        if(!$result) echo "Signin_nOk";
        else echo "Signin_Ok";
    }
?>