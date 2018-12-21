using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPurpleCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<GameObject> purplecards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Purple Card"))
		{
			purplecards.Add(card);
		}

		int randomcard = Random.Range (0, purplecards.Count);
		var newpurplecard = Instantiate( purplecards[randomcard], transform.position, transform.rotation);
		newpurplecard.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
