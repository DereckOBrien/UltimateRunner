using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cristalCounter2 : MonoBehaviour {


	public static float p2c = 0;
	public Text counterText2;
	// Use this for initialization
	void Start () {
	
		counterText2 = GetComponent<Text> () as Text;

	}
	
	// Update is called once per frame
	void Update () {
		counterText2.text = p2c.ToString  ("0") +" Cristals";
	
	}
}
