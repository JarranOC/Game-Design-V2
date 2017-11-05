using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {

    public GameObject player;
    public Transform playerPrefab;
    bool shootPlayer = false;
    int count = 0;

    public Transform[] targetPositions;

    Vector3 currentPosition;
    int nextPosition;

    public float moveSpeed = 0.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        transform.position = Vector3.MoveTowards(currentPosition, targetPositions[nextPosition].position, moveSpeed);

        if (currentPosition == targetPositions[nextPosition].position)
        {
            nextPosition++;
            if (nextPosition >= targetPositions.Length)
            {
                nextPosition = 0;
            }
        }

        if (shootPlayer)
        {
            //Thread.Sleep(2000);
            count++;
            Debug.Log("enemy: shooting");
            Destroy(player);
            GameMaster gm = new GameMaster();
            gm.respawn();
            shootPlayer = false;
        }

        if (count == 5)
        {
            //Destroy(player);
            //GameMaster gm = new GameMaster();
            //gm.respawn();
            //shootPlayer = false;
        }

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {


        if (trigger.tag == "Player")
        {
            player = trigger.gameObject;

            shootPlayer = true;
        }

        //if (trigger.tag == "Player")
        //{
        //    Debug.Log("Dying!");
        //}
    }

}
