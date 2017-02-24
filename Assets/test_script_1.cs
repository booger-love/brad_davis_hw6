using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script_1 : MonoBehaviour {

    private Rigidbody rb;
    public float parameter2 = 10;
	// Use this for initialization
	void Start () {
		//when the game starts, the text below will be displayed and the rigidbody component will also be called.
        print("Never name your script something this stupid, ever!");
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//This line add physical force to an object, the relative force upwards multiplied by 10 and the number of inputs
        rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical"));
		//here torque is added to the object leftwards multiplied by 10 and the number of inputs triggered.
        rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical"));
	}
}
