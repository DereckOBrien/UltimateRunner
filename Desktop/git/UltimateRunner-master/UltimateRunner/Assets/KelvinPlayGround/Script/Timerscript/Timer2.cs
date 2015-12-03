using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer2 : MonoBehaviour {


	public Text counterText2;
	
	public static float seconds2, minutes2;

	// Use this for initialization
	void Start () {

		counterText2 = GetComponent<Text> () as Text;
	
	}
	
	// Update is called once per frame
	void Update () {

		timer ();
	
	}

	void timer(){
		minutes2 = (int)(Time.timeSinceLevelLoad / 60f);
		seconds2 = (int)(Time.timeSinceLevelLoad % 60f);
		counterText2.text = minutes2.ToString ("00") + ":" + seconds2.ToString("00");


	}
}
