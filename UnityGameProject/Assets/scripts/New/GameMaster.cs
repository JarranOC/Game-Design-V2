using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;
    public GameObject playerfrom;

    private int count = 0;

    void Start () {
		if (gm == null) {
			gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
		}

        if (count > 2)
        {
            Debug.Log("okay can do game over now");
        }
	}

	public Transform playerPrefab;
	public Transform spawnPoint;
	public int spawnDelay = 2;

	public IEnumerator RespawnPlayer () {
		Debug.Log ("TODO: Add waiting for spawn sound");
		yield return new WaitForSeconds (spawnDelay);

		Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
		Debug.Log ("TODO: Add Spawn Particles");
	}

	public void KillPlayer (Player player) {
		Destroy (player.gameObject);
        count++;
        gm.StartCoroutine (gm.RespawnPlayer());
	}

    public void respawn()
    {
        count++;
        gm.StartCoroutine(gm.RespawnPlayer());
    }

    public void KillEnemy(enemy enemy)
    {
        Destroy(enemy.gameObject);
    }

}