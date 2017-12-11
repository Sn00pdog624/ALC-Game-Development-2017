using UnityEngine;
using System.Collections;

public class Smooth_Camera : MonoBehaviour {
	[SerializeField]Transform target;
	[SerializeField]Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
	[SerializeField]float distanceDamp = 10f;
	[SerializeField]float rotationalDamp = 10f;


	Transform myT;

	void Awake()
	{
		myT = transform;
	}


	void LateUpdate()
	{
		Vector3 toPos = target.position + (target.rotation * defaultDistance);
		Vector3 curPos = Vector3.Lerp(myT.position, toPos, distanceDamp * Time.deltaTime);
		myT.position = curPos;

		Quaternion toRot = Quaternion.LookRotation(target.rotation * defaultDistance);
		Quaternion curRot = Quaternion.Slerp(myT.position, toPos, distanceDamp * Time.deltaTime);
		myT.rotation = curRot;
	}
}
