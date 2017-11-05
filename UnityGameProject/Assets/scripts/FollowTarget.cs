using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Awake() {
		//target = GameObject.FindGameObjectWithTag ("EyeTransform").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		TrackTarget ();

	}
	void TrackTarget()
	{
		float targetX = target.position.x;
		float targetY = target.position.y;

		transform.position = new Vector3 (targetX, targetY, -1.9f);
	}
}
