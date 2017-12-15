using UnityEngine;
using System.Collections;

public class Battery_Respawn : MonoBehaviour {

	public GameObject Battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;


	// Use this for initialization
	void Start () {
		batSpawned = false;

	}
	
	// Update is called once per frame
	void Update () {
		if(batSpawned = false){
			StartCoroutine(SpawnBat());
		}
		else{
			prin
		}
	}

	void onTriggerEnter(Collision other){
		if(other.GameObject.tag == "Battery"){
			batSpawned = true;
		}
		else{
			batSpawned = false
		}
	}
	
	IEnumerator spawnBat(){
		yield return new WaitForSeconds(spawnTime);
		Rigidbody clone;
		(Rigidbody)Instantiate(Battery, spawnPoint.position, spawnPoint.rotation);
		
	}

}

