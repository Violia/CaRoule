using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {

    string CreateUserURL = "http://cyrilleclerc.000webhostapp.com/InsertPlayer.php";

    void OnCollisionEnter()
	{
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", "PlayerY");
        form.AddField("passwordPost", "LoLz");
        form.AddField("highscorePost", "19");

        WWW www = new WWW(CreateUserURL, form);
        www.ToString();
        
        Invoke("Reload", 1.59f);
	}

	void Reload()
	{
        Application.LoadLevel(Application.loadedLevel);

    }
}
