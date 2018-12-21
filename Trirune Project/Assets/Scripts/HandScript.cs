using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {

    public GameObject[] cards;

    public GameObject[] draw;

    public GameObject Selector;


	// Use this for initialization
	void Start () {
        StartCoroutine(DrawFirstCards());
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private IEnumerator DrawFirstCards()
    {
        yield return new WaitForSeconds(1.0f);
        
        if (Selector.GetComponentInChildren<SelectorCard>().cardColour[0] == "Bl")
        {
            if(Selector.GetComponentInChildren<SelectorCard>().cardAmount[0] == 1)
            {
                var firstcard = Instantiate(draw[0], cards[0].transform.position, cards[0].transform.rotation);
                firstcard.transform.parent = cards[0].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[0] == "Gr")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[0] == 1)
            {
                var firstcard = Instantiate(draw[1], cards[0].transform.position, cards[0].transform.rotation);
                firstcard.transform.parent = cards[0].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[0] == "Or")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[0] == 1)
            {
                var firstcard = Instantiate(draw[2], cards[0].transform.position, cards[0].transform.rotation);
                firstcard.transform.parent = cards[0].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[0] == "Pu")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[0] == 1)
            {
                var firstcard = Instantiate(draw[3], cards[0].transform.position, cards[0].transform.rotation);
                firstcard.transform.parent = cards[0].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[0] == "Ye")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[0] == 1)
            {
                var firstcard = Instantiate(draw[4], cards[0].transform.position, cards[0].transform.rotation);
                firstcard.transform.parent = cards[0].transform;
            }
        }
        StartCoroutine(DrawSecondCards());
        StopCoroutine(DrawFirstCards());
        
    }

    private IEnumerator DrawSecondCards()
    {
        yield return new WaitForSeconds(1.0f);

        if (Selector.GetComponentInChildren<SelectorCard>().cardColour[1] == "Bl")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[1] == 1)
            {
                var secondcard = Instantiate(draw[0], cards[1].transform.position, cards[1].transform.rotation);
                secondcard.transform.parent = cards[1].transform;
            }
        }
        else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[1] == "Gr")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[1] == 1)
            {
                var secondcard = Instantiate(draw[1], cards[1].transform.position, cards[1].transform.rotation);
                secondcard.transform.parent = cards[1].transform;
            }
        }
        else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[1] == "Or")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[1] == 1)
            {
                var secondcard = Instantiate(draw[2], cards[1].transform.position, cards[1].transform.rotation);
                secondcard.transform.parent = cards[1].transform;
            }
        }
        else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[1] == "Pu")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[1] == 1)
            {
                var secondcard = Instantiate(draw[3], cards[1].transform.position, cards[1].transform.rotation);
                secondcard.transform.parent = cards[1].transform;
            }
        }
        else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[1] == "Ye")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[1] == 1)
            {
                var secondcard = Instantiate(draw[4], cards[1].transform.position, cards[1].transform.rotation);
                secondcard.transform.parent = cards[1].transform;
            }
        }
        StartCoroutine(DrawLastCards());
        StopCoroutine(DrawSecondCards());

    }

    private IEnumerator DrawLastCards()
    {
        yield return new WaitUntil(() => Selector.GetComponentInChildren<SelectorCard>().cardColour[2] != "Na");

        if (Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Bl")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[2] == 2)
            {
                var thirdcard = Instantiate(draw[0], cards[2].transform.position, cards[2].transform.rotation);
                thirdcard.transform.parent = cards[2].transform;

                var fourthcard = Instantiate(draw[0], cards[3].transform.position, cards[3].transform.rotation);
                fourthcard.transform.parent = cards[3].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Gr")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[2] == 2)
            {
                var thirdcard = Instantiate(draw[1], cards[2].transform.position, cards[2].transform.rotation);
                thirdcard.transform.parent = cards[2].transform;

                var fourthcard = Instantiate(draw[1], cards[3].transform.position, cards[3].transform.rotation);
                fourthcard.transform.parent = cards[3].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Or")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[2] == 2)
            {
                var thirdcard = Instantiate(draw[2], cards[2].transform.position, cards[2].transform.rotation);
                thirdcard.transform.parent = cards[2].transform;

                var fourthcard = Instantiate(draw[2], cards[3].transform.position, cards[3].transform.rotation);
                fourthcard.transform.parent = cards[3].transform;
            }
        } else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Pu")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[2] == 2)
            {
                var thirdcard = Instantiate(draw[3], cards[2].transform.position, cards[2].transform.rotation);
                thirdcard.transform.parent = cards[2].transform;

                var fourthcard = Instantiate(draw[3], cards[3].transform.position, cards[3].transform.rotation);
                fourthcard.transform.parent = cards[3].transform;
            }
        }
        else if (Selector.GetComponentInChildren<SelectorCard>().cardColour[2] == "Ye")
        {
            if (Selector.GetComponentInChildren<SelectorCard>().cardAmount[2] == 2)
            {
                var thirdcard = Instantiate(draw[4], cards[2].transform.position, cards[2].transform.rotation);
                thirdcard.transform.parent = cards[2].transform;

                var fourthcard = Instantiate(draw[4], cards[3].transform.position, cards[3].transform.rotation);
                fourthcard.transform.parent = cards[3].transform;
            }
        }


        StopCoroutine(DrawLastCards());

    }
}
