using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawYellowCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<GameObject> yellowcards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Yellow Card"))
		{
			yellowcards.Add(card);
		}

		int randomcard = Random.Range (0, yellowcards.Count);
		var newyellowcard = Instantiate( yellowcards[randomcard], transform.position, transform.rotation);
		newyellowcard.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
