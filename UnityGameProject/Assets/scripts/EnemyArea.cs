using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyArea : MonoBehaviour {

    public GameObject player;
    public Transform playerPrefab;
    bool shootPlayer = false;
    int count = 0;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
        if (shootPlayer)
        {
            //Thread.Sleep(2000);
            count++;
            Debug.Log("shooting");
        }

        if (count == 5)
        {
            Destroy(player);
            GameMaster gm = new GameMaster();
            gm.respawn();
            count++;
        }

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.LogAssertion("test");

        if (trigger.tag == "Player")
        {
            shootPlayer = true;
            player = trigger.gameObject;
        }

        //if (trigger.tag == "Player")
        //{
        //    Debug.Log("Dying!");
        //}
    }
}
