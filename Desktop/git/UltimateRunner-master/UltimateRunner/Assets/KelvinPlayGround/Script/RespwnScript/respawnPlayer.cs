using UnityEngine;
using System.Collections;

public class respawnPlayer : MonoBehaviour {

	private GameObject f1;


	public Transform spawnpoint;
	public GameObject Player;

	public GameObject Player2;





	void Awake(){

		Player = GameObject.Find ("Player1");
		Player2 = GameObject.Find ("Player2");
	}

	// Use this for initialization
	void Start () 
	{



	}
	
	// Update is called once per frame
	void Update () 
	{
	
		

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player" ) 
		{


			spawnplayer();
		}

		if (other.tag == "player2") {

			spawnplayer2();

		}



	}

	void spawnplayer(){

		Player.transform.position = spawnpoint.position;

	}

	void spawnplayer2(){
		
		Player2.transform.position = spawnpoint.position;
		
	}





}
