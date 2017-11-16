using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

	public bool lightOn;

	Light light;

	// Use this for initializtion
	void Start () {
		light = GetComponent<Light> ();
		// Set Light default to ON
		lightOn = true;
		light.enabled = true;
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.L) && lightOn) {
			lightOn = false;
			light.enabled = false;

		}

		else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
			print("Light On");
			lightOn = true;
			light.enabled = true;

	    }
    }
	public void setLightOn(){
		lightOn = true;
	}

	public bool isLightOn(){
		return lightOn;
	}
}
