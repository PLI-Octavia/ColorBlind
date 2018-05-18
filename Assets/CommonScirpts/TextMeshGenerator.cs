using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshGenerator : MonoBehaviour {


   
    private string tag;
    private TextMesh mesh;

    //public System.Random rnd = new System.Random();
    // Use this for initialization
    void Start () {
        this.initAnswer();
    }
	
    //Choix de la question
    void initAnswer()
    { 
        //we take a random color
        int index = Singleton.Instance.rnd.Next(0, Singleton.Instance.colorBlockArray.Count - 1);


        //Set opt of the text Mesh
        this.mesh = this.GetComponent<TextMesh>();
        this.tag = Singleton.Instance.allColorAvaible[index];
        this.mesh.text = tag;
        this.name = tag;
        Singleton.Instance.answer = tag;
        List<string> list = new List<string>(Singleton.Instance.allColorAvaible);
        list.RemoveAt(index);
        Singleton.Instance.allColorAvaible = list.ToArray();
        this.mesh.fontSize = 50;
        this.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
