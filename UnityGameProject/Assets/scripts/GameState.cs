using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour 
{
	private GameObject[] coins;
	public int totalCoins;
	private CoinCounter coinCounter;
	//private LivesCounter livesCounter;


	void Awake () 
	{
		coinCounter = GameObject.Find ("CoinText").GetComponent<CoinCounter>();
		//livesCounter = GameObject.Find ("LivesText").GetComponent<LivesCounter>();

		coins = GameObject.FindGameObjectsWithTag("Coin");
		totalCoins = coins.Length;
	}
	

	void Update () 
	{
		
		int collectedCoins;
		collectedCoins = coinCounter.coinCount;

		//livesCounter.extraLives = collectedCoins / totalCoins;
		//if(livesCounter.totalLives < 0)
		{
			print("GAME OVER!");
		}


	
	}
}
