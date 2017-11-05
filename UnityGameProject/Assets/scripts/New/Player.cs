using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[System.Serializable]
	public class PlayerStats {
		public int Health = 100;
	}

	public PlayerStats playerStats = new PlayerStats();

	public int fallBoundary = -20;

    GameMaster gm = new GameMaster();

	void Update () {
		if (transform.position.y <= fallBoundary)
			DamagePlayer (9999999);
	}

	public void DamagePlayer (int damage) {
		playerStats.Health -= damage;
		if (playerStats.Health <= 0) {
            gm.KillPlayer(this);
		}
	}

    public void killthis()
    {
        gm.KillPlayer(this);
    }

}
