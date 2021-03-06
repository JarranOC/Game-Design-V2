﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
	public CharacterMovement character;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ground") {
			character.grounded = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Ground") {
			character.grounded = false;
		}
	}
}
