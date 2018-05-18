using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    // This field can be accesed through our singleton instance,
    // but it can't be set in the inspector, because we use lazy instantiation
    public int number;
    public System.Random rnd = new System.Random();
    public int score = 0;
    public Dictionary<string, Color> colorBlockArray = new Dictionary<string, Color>();
    public ArrayList ar = new ArrayList();
    public string answer;
    // Static singleton instance
    private static Singleton instance;
    public int answerNow = 0;
    public  string[] allColorAvaible = new string[] { "blue", "red", "yellow", "purple", "pink", "black", "green" };
    private Singleton()
    {
        SetColor();
    }
    // Static singleton property
    public static Singleton Instance
    {
        // Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
        // otherwise we assign instance to a new component and return that
        
        get { return instance ?? (instance = new GameObject("Singleton").AddComponent<Singleton>()); }
    }

    //Set the color array
    public void SetColor()
    {
        colorBlockArray.Add("red", Color.red);
        colorBlockArray.Add("yellow", Color.yellow);
        colorBlockArray.Add("black", Color.black);
        colorBlockArray.Add("blue", Color.blue);
        colorBlockArray.Add("green", Color.green);
        colorBlockArray.Add("pink", new Color(1, 0, 0.78f));
        colorBlockArray.Add("purple", new Color(0.84f, 0, 1));

    }
}