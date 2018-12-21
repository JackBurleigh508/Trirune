using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSelectorCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<GameObject> selectorcards = new List<GameObject>();

        foreach (GameObject card in GameObject.FindGameObjectsWithTag("Selector Card"))
        {
           selectorcards.Add(card);
        }

        int randomcard = Random.Range(0, selectorcards.Count);
        var newselectorcard = Instantiate(selectorcards[randomcard], transform.position, transform.rotation);
        newselectorcard.transform.parent = this.transform;
        newselectorcard.transform.localScale = new Vector3(50, 50, 50);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
