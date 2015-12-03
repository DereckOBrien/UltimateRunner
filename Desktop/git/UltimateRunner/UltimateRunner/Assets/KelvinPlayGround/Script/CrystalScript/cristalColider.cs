using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cristalColider : MonoBehaviour {









	// Use this for initialization
	void Start () {


	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player") {
			

			cristalCounter.p1c++;
			Destroy(this.gameObject);


		}

		if (other.tag == "player2") {
			

			cristalCounter2.p2c++;
			Destroy(this.gameObject);




			
		}
	}


	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3(0,0,10));

	
	}
}
