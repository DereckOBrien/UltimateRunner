using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour 
{



	public GameObject[] TrackPrefabs;

	public GameObject CurrentTrack;

	private  int GameLength;

	GameLength gl2 = new GameLength();

	public GameObject AminuTest1;




	// Use this for initialization
	void Start () 
	{

		GameLength = gl2.Name;
		Debug.Log (GameLength);
		for(int i = 0; i < GameLength ; i++){
			spawnTrack ();

			
			
		}
		Instantiate (AminuTest1, CurrentTrack.transform.GetChild (0).transform.GetChild (3).position, Quaternion.identity);



	}
	
	// Update is called once per frame
	void Update () {
	


	}






	public void spawnTrack()
	{
		int randomnumber = Random.Range (0,4);
		CurrentTrack = (GameObject) Instantiate (TrackPrefabs[randomnumber], CurrentTrack.transform.GetChild (0).transform.GetChild (3).position, Quaternion.identity);

	}


}
