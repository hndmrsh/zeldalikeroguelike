using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private string testString;

	// Use this for initialization
	void Start () {
        testString = "This is a test string";
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(testString);
	}
}
