using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour {
    public float max = 10;
    public float min = 1;
    public float speed = 2;
    private bool goingUp;

	// Update is called once per frame
	void Update () {
        if(transform.position.y < min + 0.1)
        {
            goingUp = true;
        }
        if(transform.position.y > max - 0.1)
        {
            goingUp = false;
        }
        if (goingUp) {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, max, transform.position.z), Time.deltaTime * speed);
        } else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, min, transform.position.z), Time.deltaTime * speed);
        }

    }
}
