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
                //TODO check la réponse par rapport à l'info envoyée et changer la couleur
                block.GetComponent<Renderer>().material.color = Singleton.Instance.colorBlockArray[tag];
            }
        }
        else
        {
            Debug.Log("Perdu");
        }
    }
}
