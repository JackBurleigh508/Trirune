using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceWires : MonoBehaviour {

    public string colour;
    //public GameObject Convert;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SWires")
        {
            if(other.gameObject.GetComponent<SocketWires>().colour != colour )
            {
                if(other.gameObject.GetComponent<SocketWires>().colour != "NA")
                {
                    this.gameObject.GetComponentInParent<movePiece>().status = "hand";
                }
            }
            else {
                other.gameObject.GetComponent<SocketWires>().colour = colour;
                //Convert.SetActive(true);
            }
        }
    }
}
