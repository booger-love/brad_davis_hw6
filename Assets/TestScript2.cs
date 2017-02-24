using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour {
    private Rigidbody rb;
    public float parameter1;
    private Renderer rend;
	// Use this for initialization
	void Start () {
		//initializes rigidbody phsysics and renderer at start of game
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
	}
	
    void Update()
    {
		//everytime the trigger is pulled, or fire button pressed..
        if (Input.GetButtonDown("Fire1"))
        {
		//then we are going to get an output of randomly colored projectiles
            Color color = Random.ColorHSV();
            rend.material.SetColor("_Color", color);
            
        }
    }
	//this is the collision that occurs when firing colored projectiles
	void OnCollisionEnter(Collision collision)
    {
		//with an upward force multiplied by the float variable, parameter1
        rb.AddForce(Vector3.up * parameter1);
    }
}
