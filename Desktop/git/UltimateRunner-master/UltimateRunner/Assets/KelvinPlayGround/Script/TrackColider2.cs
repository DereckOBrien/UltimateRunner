using UnityEngine;
using System.Collections;

public class TrackColider2 : MonoBehaviour {

	public TrackManager _tmanager;

	// Use this for initialization
	void Start () {

	
	}


	void OnTriggerEnter(Collider coll){
		
		Debug.Log (gameObject.name +" was triggered by[Small wall hit]" +coll.gameObject.name);
		//for(int i = 0; i < glength ; i++){
		_tmanager.spawnTrack ();
		//}
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
