using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteckClickAndChange : MonoBehaviour {

    // Use this for initialization
    void Start () {
            
    }
	
	// Update is called once per frame
	void Update () {
		    
	}


    private void OnMouseDown()
    {
        GameObject[] blocksToChange;
        string tag;

        tag = this.gameObject.tag;

        if (tag == Singleton.Instance.answer)
        {
            //We search every GO with the tag of the color selected
            blocksToChange = GameObject.FindGameObjectsWithTag(tag);

            foreach (GameObject block in blocksToChange)
            {
                if (block.name != "Cube")
                {
                    Debug.Log(tag);
                    Singleton.Instance.colorBlockArray.Remove(tag);
                    Destroy(block);
                }
                else
                {
                    block.GetComponent<Renderer>().material.color = Singleton.Instance.colorBlockArray[tag];
                }
            }
            Singleton.Instance.answerNow = 0;
        }
        else
        {
            Debug.Log("Perdu");
        }



    }
}
