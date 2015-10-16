﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {


    /**
        public global variables for the quit menu canvas.
    */

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start () {

        // get all UI component inside the (quitMenu canvas)
        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;

        startText = startText.GetComponent<Button>();
        exitText = startText.GetComponent<Button>();




    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void ExitPress() {

        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;

    }


    public void NoPress(){

        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;

    }

    public void StartGame() {

        Application.LoadLevel(1);
    }


    public void ExitGame() {

        Application.Quit();

    }




}
