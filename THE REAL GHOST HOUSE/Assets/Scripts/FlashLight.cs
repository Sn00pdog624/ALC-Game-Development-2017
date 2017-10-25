using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FlashLight : MonoBehaviour {

public bool lightOn;
Light Light;

void Start () {
	light = GetComponent<Light> ();
	lightOn = true;
	light.enabled = true;
}

void Update () {
	if (Imput.GetKeyUp (KeyCode.l) && lighton) {
		lightOn = false;
		light.enabled = false;


	}

	else if (Imput.GetKeyUp (KeyCode.L) && !lightOn){
		lightOn = true;
		light.enabled = true;
	     }
    }
}
