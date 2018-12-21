using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void rotateLeft()
	{
		GameObject.FindGameObjectWithTag("Selected").transform.Rotate (0, 0, 60);

        if (GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up == true)
        {
            GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up = false;
        } else if (GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up == false)
        {
            GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up = true;
        }
    }

	public void rotateRight()
	{
		GameObject.FindGameObjectWithTag("Selected").transform.Rotate (0, 0, -60);

        if (GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up == true)
        {
            GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up = false;
        }
        else if (GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up == false)
        {
            GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().up = true;
        }
    }
}
