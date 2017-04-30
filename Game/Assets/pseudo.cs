using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pseudo : MonoBehaviour {
	string CreateUserURL = "http://cyrilleclerc.000webhostapp.com/Connection.php";
	public string Pseudo;
	public string mdp;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void the_pseudo(InputField newText1)
	{
		Pseudo = newText1.text;
	}
	public void the_mdp(InputField newText2)
	{
		mdp = newText2.text;
	}
	public void validating()
	{
		WWWForm form = new WWWForm();
		form.AddField("usernamePost", Pseudo);
		form.AddField("passwordPost", mdp);

		WWW www = new WWW(CreateUserURL, form);
		PlayerPrefs.SetString ("SavePseudo", Pseudo);
		//test1 (Pseudo, mdp);
		Application.LoadLevel ("waaaaa");
	}

	IEnumerator test1(string pseudo, string mdp)
	{
		print ("bwaa");
		WWWForm form = new WWWForm();
		form.AddField("usernamePost", Pseudo);
		form.AddField("passwordPost", mdp);

		WWW www = new WWW(CreateUserURL, form);
		yield return www;
		string PlayersDataString = www.ToString();
		print(PlayersDataString);
		print ("ok");
	}
}
