using UnityEngine;
using System.Collections;

public class CollisionTracker2 : MonoBehaviour {

	void OnTriggerEnter(Collider coll){
		
		Debug.Log (gameObject.name +" was triggered by[Big wall hit]" +coll.gameObject.name);
		Destroy (gameObject);
		
		
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}
