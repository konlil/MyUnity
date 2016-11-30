using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	float forwardSpeed = 30.0f;
	float turnSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float turnAmount = Input.GetAxis ("Horizontal") * turnSpeed;
		float forwarAmount = Input.GetAxis ("Vertical") * forwardSpeed;

		transform.Rotate (0, turnAmount, 0);

		GetComponent<Rigidbody>().AddRelativeForce (forwarAmount, 0, 0);
	}
}
