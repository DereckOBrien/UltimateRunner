using UnityEngine;
using System.Collections;


public class SaveScores : MonoBehaviour {



	//Timer tim = new Timer ();
	//Timer2 tim2 = new Timer2 ();
	//cristalCounter cr = new cristalCounter ();
	//cristalCounter2 cr2 = new cristalCounter2 ();

	public static float M1;
	public static float M2;

	public static float C1;
	public static float C2;

	public static float p1;
	public static float p2;
	



	void Start () {

		M1 = Timer.minutes;
		M2 = Timer2.minutes2;
		C1 = cristalCounter.p1c;
		C2 = cristalCounter2.p2c;


		p1 = M1 * C1;
		p2 = M2 * C2;
	
	}
	
	// Update is called once per frame
	void Update () {

		print (M1);
		print (M2);
	
	}





}
