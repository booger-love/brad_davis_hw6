using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript4 : MonoBehaviour {

    public float life = 100;

	// Use this for initialization
	void Start () {
		
	}
	//this line states that when there is a collision, the following conditions apply
	void OnCollisionEnter(Collision collision)
    {
		//this prints the name of the collider you hit with your projectile
        print(collision.collider.name);
		//if the collision is with with a collider that is not named "terrain"
        if(collision.collider.name != "Terrain")
        {
		//life = life - the damage of the collider on the component
            life -= collision.collider.GetComponent<damageValue>().getDamage();
        }
		//if the life of the game object is less than zero, then it is destroyed.
        if(life < 0)
        {
            Destroy(gameObject);
        }
    }
}
