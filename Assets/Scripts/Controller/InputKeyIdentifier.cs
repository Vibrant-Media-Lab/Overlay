using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyIdentifier : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vKey))
            {
                //your code here
                Debug.Log("Key pressed: <" + vKey + ">");
            }
        }

        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            Debug.Log("Horizontal: " + Input.GetAxisRaw("Horizontal"));
        }

        if (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0)
        {
            Debug.Log("Vertical: " + Input.GetAxisRaw("Vertical"));
        }
    }
}
