using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBlueCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<GameObject> bluecards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Blue Card"))
		{
			bluecards.Add(card);
		}

		int randomcard = Random.Range (0, bluecards.Count);
		var newbluecard = Instantiate( bluecards[randomcard], transform.position, transform.rotation);
		newbluecard.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
