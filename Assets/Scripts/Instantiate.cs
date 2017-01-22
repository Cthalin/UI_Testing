using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    [SerializeField]
    private GameObject ButtonPrefab;

	// Use this for initialization
	void Start () {
        //GameObject prefab = ButtonPrefab.Load("Button") as GameObject;
        GameObject button2 = Instantiate(ButtonPrefab);
        button2.transform.parent = ButtonPrefab.transform.parent;
        GameObject button3 = Instantiate(ButtonPrefab);
        button3.transform.parent = ButtonPrefab.transform.parent;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
