using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionViews : MonoBehaviour {

    private float initX = -10.15f;
    private float initY = 0.5f;
    private float initZ = -2.5f;

    void Start()
    {
        this.affColorPalette();
        
    }

    private void Update()
    {
        if (Singleton.Instance.answerNow == 0 && Singleton.Instance.colorBlockArray.Count != 0)
        {
            Singleton.Instance.answerNow = 1;
            this.affOneQuestion();
        } else if(Singleton.Instance.colorBlockArray.Count == 0) {
            //On load le menu
            Debug.Log("Go menu");
        }
    }


    //Init color palette
    private void affColorPalette()
    {
        //We get all the color as GA
        var tmp = Resources.LoadAll("GameObject/ColorPalette", typeof(GameObject));

        //Calcul the interval between each color
        float interval = this.getInterval();

        //Aff the color on the map
        foreach (GameObject color in tmp)
        {
            GameObject Param1Child = Instantiate(color) as GameObject;
            Param1Child.transform.position = new Vector3(initX, initY, initZ);
            initX += interval;
        }
    }

    private void affOneQuestion()
    {
        GameObject question = new GameObject();
        question.AddComponent<TextMesh>();
        question.AddComponent<TextMeshGenerator>();
        question.transform.position = new Vector3(-13.5f, 7.2f, 7f);
        
    }

    //Calcul interval between each color
    private float getInterval()
    {
        float screenSize = Screen.width;
        return (screenSize / 10) / 50;
    }
}
    