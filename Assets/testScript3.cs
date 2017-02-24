using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript3 : MonoBehaviour
{

    public GameObject projectile;
    public float force = 20;
    private GameObject clone;

    // Update is called once per frame
    void Update()
    {
		//when fire button is pressed
        if (Input.GetButtonDown("Fire1"))
        {
		//then we get projectiles that rotate and move in a forward motion
            clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
		//this is the rigidbody physics and forces that are applied to the projectile
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * force);
        }
    }
}
