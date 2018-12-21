using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGreenCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<GameObject> greencards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Green Card"))
		{
			greencards.Add(card);
		}

		int randomcard = Random.Range (0, greencards.Count
                                      
                                      
                                      );
		var newgreencard = Instantiate( greencards[randomcard], transform.position, transform.rotation);
		newgreencard.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
