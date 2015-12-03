using UnityEngine;
using System.Collections;

public class Trackcollider : MonoBehaviour {


	public TrackManager _tmanager;



	public int glength;

	// Use this for initialization
	void Start () {


		//glength = _tmanager.GameLength;

	
	}



	void OnTriggerEnter(Collider coll){
		
		Debug.Log (gameObject.name +" was triggered by[Small wall hit]" +coll.gameObject.name);
		for(int i = 0; i < glength ; i++){
			_tmanager.spawnTrack ();


		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
