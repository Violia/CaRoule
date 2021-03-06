﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {
	public Text counterText;
	public float seconds, minutes;
	// Use this for initialization
	void Start () {
		counterText = GetComponent<Text> () as Text;
	}
	
	// Update is called once per frame
	void Update () {
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		counterText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
	}
}
