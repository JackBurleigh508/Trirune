using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFin : MonoBehaviour {

    public GameObject[] Sockets;
    public GameObject WinScreen;
    //public GameObject GameScreen;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Sockets[0].GetComponent<socketScript>().empty == false &&
            Sockets[1].GetComponent<socketScript>().empty == false &&
            Sockets[2].GetComponent<socketScript>().empty == false &&
            Sockets[3].GetComponent<socketScript>().empty == false )
        {
            WinScreen.SetActive(true);
           // GameScreen.SetActive(false);
        }
	}
}
