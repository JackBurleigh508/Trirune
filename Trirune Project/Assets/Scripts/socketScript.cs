using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socketScript : MonoBehaviour {

	public string colour = "NA";
	public string rune = "NA";
    public bool empty = true;

    void Update()
    {
        //empty = true;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.GetComponent<movePiece>().status == "placed")
        {
            empty = false;
        } else
        {
            empty = true;
        }
    }
}
