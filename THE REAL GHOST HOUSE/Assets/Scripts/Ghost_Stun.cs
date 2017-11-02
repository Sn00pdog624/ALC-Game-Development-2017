using UnityEngine;
using System.Collections;

public class Ghost_Stun : MonoBehaviour {

	//bool lightCheck;

	// Use this for initialization
	void Start () {
		//lightCheck = GetComponent<Flashlight>().LightOn;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other){
		
		if(other.gameObject.name == "Ghost"){
			print("Ghost is stunned!");

		}
	}
}
