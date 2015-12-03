using UnityEngine;
using System.Collections;

public class SetCountDown : MonoBehaviour {

    private GameManagerScript GMS;

    public void SetCountDownNow() {

        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;

    }
    void Update()
    {
        if (GMS.counterDownDone == true)
        {
            Application.LoadLevel(2);
        }
    }
}
