using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliffTrigger : MonoBehaviour {

	public bool playerRight;
	private Animator anim;

	// Use this for initialization
	void Awake() {
		anim = GameObject.Find ("Boss_Rig").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			anim.SetBool ("playerRight", playerRight);
		}


	}
}
