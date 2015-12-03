using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text counterText;

	public static float seconds, minutes;

	void Start () {

		counterText = GetComponent<Text> () as Text;
	
	}
	
	// Update is called once per frame
	void Update () {

		timer ();
	
	}

	void timer(){

		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		counterText.text = minutes.ToString ("00") + ":" + seconds.ToString("00");
	}
}
