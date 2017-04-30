using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    public string[] players;

	// Use this for initialization
	IEnumerator Start () {
        WWW PlayersData = new WWW("http://cyrilleclerc.000webhostapp.com/ItemsData.php");
        yield return PlayersData;
        string PlayersDataString = PlayersData.text;
        print(PlayersDataString);
        players = PlayersDataString.Split(';');
        for(int z = 0; z < players.Length; z++)
        {
            print(GetDataValue(players[z], "Player:"));
            print(GetDataValue(players[z], "HighScore:"));
        }
    }

    string GetDataValue(string data, string index)  {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if(value.Contains("|"))
            value = value.Remove(value.IndexOf("|"));
        return value;
    }

}
