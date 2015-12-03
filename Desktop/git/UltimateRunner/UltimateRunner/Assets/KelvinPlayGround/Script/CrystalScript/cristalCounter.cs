using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cristalCounter : MonoBehaviour {

	public static float p1c = 0;


	public Text counterText1;




	void Start () {
		
		counterText1 = GetComponent<Text> () as Text;


		
	}

	void Update () {
		counterText1.text = p1c.ToString  ("0") +" Cristals";


		
	}
}
