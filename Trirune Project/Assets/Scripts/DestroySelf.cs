using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(10.0f);
        Object.Destroy(this.gameObject);
    }
}
