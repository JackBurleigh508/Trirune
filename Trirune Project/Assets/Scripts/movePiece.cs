using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePiece : MonoBehaviour {

    public string status; //pickedup, placed, hand
	public string colour;
	public string rune;
	public string tagged;

	public bool up;
	public bool selected;

    public GameObject Wires;
    public GameObject Convert;
    private GameObject parent;

    void Start () {
		
		tagged = this.tag;
        //parent = this.parent;

	}
	
	
	void Update () {

		

		if (status == "pickedup") {
			
			Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = objPosition;
		}
        

        if (status == "placed")
        {
            selected = false;

            Wires.SetActive(true);
            Convert.SetActive(true);
        }

        if(status == "hand")
        {
            transform.position = transform.parent.position;
        }


		if (selected == true) {
			this.tag = "Selected";

            Wires.SetActive(false);
            Convert.SetActive(false);
        } else if (selected == false) {
			this.tag = tagged;
		}

        

	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (status != "pickedup") {
			if (other.gameObject.GetComponent<socketScript>().empty == true)
			{
				if (other.gameObject.GetComponent<socketScript> ().colour == "NA" && other.gameObject.GetComponent<socketScript> ().rune == "NA") {
					if (up == true) {
						if (other.gameObject.tag == "Primary Socket") {
							transform.position = other.gameObject.transform.position;
							other.gameObject.GetComponent<socketScript> ().empty = false;
                            status = "placed";
						} else {
                            transform.position = transform.parent.position;
                        }
                    } else if (up == false) {
						if (other.gameObject.tag == "Secondary Socket") {
							transform.position = other.gameObject.transform.position;
							other.gameObject.GetComponent<socketScript> ().empty = false;
                            status = "placed";
						} else {
							transform.position = transform.parent.position;
						}
					}
				} else if (other.gameObject.GetComponent<socketScript> ().colour == colour || other.gameObject.GetComponent<socketScript> ().rune == rune) {
					if (up == true) {
						if (other.gameObject.tag == "Primary Socket") {
							transform.position = other.gameObject.transform.position;
							other.gameObject.GetComponent<socketScript> ().empty = false;
                            status = "placed";
						} else {
                            transform.position = transform.parent.position;
                        }
                    } else if (up == false) {
						if (other.gameObject.tag == "Secondary Socket") {
							transform.position = other.gameObject.transform.position;
							other.gameObject.GetComponent<socketScript> ().empty = false;
                            status = "placed";
						} else {
							transform.position = transform.parent.position;
						}
					}
                    

                }else
                    {
                        transform.position = transform.parent.position;
                    }
		}

	}
	}

	void OnMouseDown(){
        status = "pickedup";

        if(selected == false)
        {
            selected = true;
        }
        GameObject.FindGameObjectWithTag("Selected").GetComponent<movePiece>().selected = false;
        selected = true;
	}




	void OnMouseUp(){
		status = "idle";
	}
		
}
