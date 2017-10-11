using UnityEngine;
using System.Collections;

public class PLAYER_MOVE : MonoBehaviour {
    public float movespeed;
	public float turnspeed;
	public float jumpheight;



	void Update () {
		var j = Input.GetAxis("Jump")* Time.deltaTime * jumpheight;
		var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnspeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * movespeed;

		transform.Rotate (0,y,0);
		transform.Translate (0,0,z);
		transform.Translate (0,j,0);
	}
}
