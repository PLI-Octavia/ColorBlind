using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManagement : MonoBehaviour {

    public float moveSpeed = 0.0001f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Vector3.right * 0.01f);
    }
}