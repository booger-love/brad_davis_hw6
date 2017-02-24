using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicControls : MonoBehaviour {

    public float speed = 1;
    public float turn = 3;
    private bool active = true;
    private IEnumerator coroutine;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            rb.AddRelativeForce(Vector3.forward * Input.GetAxis("Vertical") * speed);
            rb.AddRelativeTorque(Vector3.up * Input.GetAxis("Horizontal") * turn);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        active = false;
        coroutine = WaitAndRestart(0.5f);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndRestart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        active = true;
    }

}
