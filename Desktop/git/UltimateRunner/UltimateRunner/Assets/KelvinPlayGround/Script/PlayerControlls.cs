using UnityEngine;
using System.Collections;

public class PlayerControlls : MonoBehaviour {


	public float speed;
	private Vector3 dir;

	// Use this for initialization
	void Start () 
	{
		dir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			dir = Vector3.forward;
		}

		float move = speed * Time.deltaTime;
		transform.Translate (dir * move);
	
	}
}
