using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamepad;

public class BallController : MonoBehaviour {

    [SerializeField]
    private Joystick ballJoystick;

    [SerializeField]
    private GameObject moveableBall;

    [SerializeField]
    private float speedModifier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 startPosition = moveableBall.transform.localPosition;

        Vector3 updatedPosition = startPosition;
        updatedPosition.x += ballJoystick.GetXAxis() * speedModifier;
        updatedPosition.z += ballJoystick.GetYAxis() * speedModifier;

        moveableBall.transform.localPosition = updatedPosition;
	}
}
