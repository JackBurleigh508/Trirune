using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOrangeCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<GameObject> orangecards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Orange Card"))
		{
			orangecards.Add(card);
		}

		int randomcard = Random.Range (0, orangecards.Count);
		var neworangecard = Instantiate( orangecards[randomcard], transform.position, transform.rotation);
		neworangecard.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
