using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform[] targetPositions;

	Vector3 currentPosition;
	int nextPosition;

	public float moveSpeed = 0.5f;

	// Update is called once per frame
	void Update () {
		currentPosition = transform.position;

		transform.position = Vector3.MoveTowards (currentPosition, targetPositions[nextPosition].position, moveSpeed);

		if (currentPosition == targetPositions[nextPosition].position) {
			nextPosition++;
			if (nextPosition >= targetPositions.Length){
				nextPosition = 0;
			}
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.transform.tag == "Player") {
			other.transform.parent = transform;
		}
	}

	void OnCollisionExit2D (Collision2D other) {
		if (other.transform.tag == "Player") {
			other.transform.parent = null;
		}
	}
}