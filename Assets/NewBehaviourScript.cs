using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    Dictionary<System.Object, int> abc = new Dictionary<System.Object, int>();

	// Use this for initialization
	void Start () {
        abc["abc"] = 1;
        abc["abc"] = 2;
        foreach (var item in abc)
        {
            Debug.Log("key = " + item.Key);
            Debug.Log("value = " + item.Value);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
