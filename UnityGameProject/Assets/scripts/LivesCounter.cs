using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class LivesCounter : MonoBehaviour 
{
	int initialLives = 3;
	public int extraLives = 0;
	public int totalLives;
	
	// Update is called once per frame
	void Update () 
	{
		totalLives = initialLives + extraLives;

		//Set the lives count text
		//guiText.text = "x" + totalLives;
	}
}
