﻿using UnityEngine;
using System.Collections;

public class Ghost_Stun : MonoBehaviour {
bool lightCheck;
	FlashLight flash;
	public GameObject ghost;
	
		
	// Use this for initialization
	
	void Start () {
		//print("Obj:" +gameObject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>());
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>();
		//bool test = gameObject.GetComponentInChildren<Light>().FlashLight.isLightOn();
		//print("Test:"+test);
		print("Obj:"+flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());	
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){				
		print(other.gameObject.name);
		print ("Collider" + flash);	
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is stunned!");
			//  other.GetComponent<Rigidbody>().velocity = Vector3.zero;
			//  other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

			other.GetComponent<Ghost_AI>().moveSpeed = 0f;
			StartCoroutine(Wait(5, other));
			// StopCoroutine(Wait(5));
			
		}
	}
	
	IEnumerator Wait(float time, Collider other){
			yield return new WaitForSeconds(time);
			other.gameObject.GetComponent<Ghost_AI>().moveSpeed = 5f;
			print("Ghost is unstunned");
			
}
	




}
