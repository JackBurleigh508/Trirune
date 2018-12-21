﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverterWires : MonoBehaviour {

    public string colour;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "SWires")
        {
            if(other.gameObject.GetComponent<SocketWires>().colour == "NA")
            {
                other.gameObject.GetComponent<SocketWires>().colour = colour;
                this.gameObject.SetActive(false);
            }
            
        }
    }
}
