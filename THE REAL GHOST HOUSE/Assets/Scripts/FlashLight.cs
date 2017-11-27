using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

	public bool lightOn;
	
	public int maxPower = 4;  // Flashlight power capacity
	
	public int currentPower;  //Usable Flashlight power  

	Light light;

	// Use this for initializtion
	void Start () {
		currentPower = maxPower;
		print("Power =" + maxPower);
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
