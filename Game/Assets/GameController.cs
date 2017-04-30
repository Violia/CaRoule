using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private bool _isOpened; // is menu opened?

    void Start()
    {
        _isOpened = false;
    }

    public void ToggleMenu()
    {
        if (_isOpened)
            CloseMenu();
        else
            OpenMenu();
        _isOpened = !_isOpened;
    }

    private void OpenMenu()
    {
        Time.timeScale = 0;
    }

    private void CloseMenu()
    {
        Time.timeScale = 1;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
