using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    [System.Serializable]
    public class EnemyStats
    {
        public int Health = 100;
    }

    public EnemyStats stats = new EnemyStats();

    GameMaster gm = new GameMaster();
    
    public void DamageEnemy(int damage)
    {
        stats.Health -= damage;
        if (stats.Health <= 0)
        {
            gm.KillEnemy(this);
        }
    }

    public void killthis()
    {
        gm.KillEnemy(this);
    }
}
