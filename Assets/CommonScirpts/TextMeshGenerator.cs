using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshGenerator : MonoBehaviour {


    private string[] allColorAvaible = new string[] { "blue", "red", "yellow", "purple", "pink", "black", "green" };
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
        int index = Singleton.Instance.rnd.Next(0, allColorAvaible.Length - 1);


        //Set opt of the text Mesh
        this.mesh = this.GetComponent<TextMesh>();
        this.tag = allColorAvaible[index];
        this.mesh.text = tag;
        this.name = tag;
        Singleton.Instance.answer = tag;
        this.mesh.fontSize = 50;
        this.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
