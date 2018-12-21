using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour {
	
	// Use this for initialization
	void Start (){
		List<GameObject> drawcards = new List<GameObject>();

		foreach(GameObject card in GameObject.FindGameObjectsWithTag("Draw Card"))
			{
			drawcards.Add(card);
			}

		int randomcard = Random.Range (0, drawcards.Count);
		Instantiate( drawcards[randomcard], transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
