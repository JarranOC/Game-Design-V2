using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour 
{
	private CharacterMovement characterMovement;
	private BossController bossController;

	// Use this for initialization
	void Awake () 
	{
		characterMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
		bossController = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void EnableBossBattle()
	{
		print ("Enable Character Movement!");
		characterMovement.enabled = true;
		bossController.inBattle = true;


	}

	void UpdateBossAttack()
	{

		bossController.UpdateAttackCount ();
	}

	void CallFireProjectile()
	{

		characterMovement.FireProjectile ();

	}
}
