using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject activeCheckpoint;
	private PlayerController player;


	void Start() {
		player = FindObjectOfType<PlayerController> ();
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void RespawnPlayer() {
		player.transform.position = activeCheckpoint.transform.position;
	}
}
