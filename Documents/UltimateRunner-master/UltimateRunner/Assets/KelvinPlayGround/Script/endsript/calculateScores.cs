using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class calculateScores : MonoBehaviour {


	public Canvas maincanvas;

	public Button PlayAgain, Mainmenu; 

	public Text scoreText1 , scoreText2 , scoretext3;




	// Use this for initialization
	void Start () {

		maincanvas = maincanvas.GetComponent<Canvas>();

		PlayAgain = PlayAgain.GetComponent<Button>();
		Mainmenu = Mainmenu.GetComponent<Button>();


		scoreText1 = scoreText1.GetComponent<Text> () as Text;

		scoreText2 = scoreText2.GetComponent<Text> () as Text;

		scoretext3 = scoretext3.GetComponent<Text> () as Text;



	
	}
	
	// Update is called once per frame
	void Update () {
		winner ();
	}

	public void Playagain(){


		Application.LoadLevel (2);


	}


	public void MainmenuSel (){

		Application.LoadLevel (0);

	}


	public void winner(){


		if (SaveScores.p1 > SaveScores.p2) {

			scoreText1.text = ("Player1 Wins The Ultimate Race. : score = " )+ SaveScores.p1.ToString("000"); 


		}

		if (SaveScores.p2 > SaveScores.p1) {
			
			scoreText1.text = ("Player2 Wins The Ultimate Race. : score = " )+ SaveScores.p2.ToString("000"); 
			
			
		}



	}



















}
