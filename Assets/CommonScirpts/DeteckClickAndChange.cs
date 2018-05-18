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
                    Singleton.Instance.colorBlockArray.Remove(tag);
                    Destroy(block);
                }
                else
                {
                    block.GetComponent<Renderer>().material.color = Singleton.Instance.colorBlockArray[tag];
                }
            }
            //We launch an other answer
            Singleton.Instance.answerNow = 0;
            //Remove element from the table
            //int index = Singleton.Instance.rnd.Next(0, Singleton.allColorAvaible.Length - 1);
            List<string> list = new List<string>(Singleton.allColorAvaible);
            int index = list.IndexOf(tag);
            list.RemoveAt(index);
            Singleton.allColorAvaible = list.ToArray();

            GameObject[] tt = GameObject.FindGameObjectsWithTag("question");
            Destroy(tt[0]);

        }
        else
        {
            Debug.Log("Perdu");
        }



    }
}
