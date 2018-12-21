using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColour : MonoBehaviour {

    public GameObject Selector;

    public string buttonColour;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void buttonPressed()
    {
        if(Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Na")
        {
            Selector.GetComponentInChildren<SelectorCard>().cardColour[2] = buttonColour;
        }
        
    }
}
