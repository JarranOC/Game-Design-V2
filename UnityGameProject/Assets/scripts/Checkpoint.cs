using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
	private BossController bossController;
	private CharacterMovement characterMovement;
	private Animator anim;
	private SmoothFollow smoothFollow;


	void Awake () 
	{
		bossController = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossController>();
		characterMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
		smoothFollow = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<SmoothFollow>();
		anim = GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<Animator> ();
	}
	

	void Update () 
	{
		
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			
			bossController.bossAwake = true;
			
			GetComponent<Collider>().isTrigger = false;
			anim.SetFloat ("speed", 0.0f);
			

			characterMovement.enabled = false;
			smoothFollow.bossCameraActive = true;
		}
	}
}
