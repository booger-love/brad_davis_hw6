using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript5 : MonoBehaviour {
    public float parameter1 = 0.1f;
    public float parameter2 = 0.1f;
    public float parameter3 = 10;
    public float parameter4 = -10;
    private bool parameter5 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if parameter 1 is greater than parameter 3 then parameter 5 is false
        if(parameter1 > parameter3)
        {
            parameter5 = false;
        }
		//if parameter 5 is true, if p1 = p1 + p2 then the amount of light in the skybox will be greater, causing world to be brighter.
        if (parameter5)
        {
            parameter1 += parameter2;
            RenderSettings.skybox.SetFloat("_Exposure", parameter1);
        } else
        {
		//else if p1 = p1 - p2 then the skybox will have less exposure and will look darker.
            parameter1 -= parameter2;
            RenderSettings.skybox.SetFloat("_Exposure", parameter1);
        }
        if(parameter1 < parameter4)
        {
            parameter5 = true;
        }

    }
}
