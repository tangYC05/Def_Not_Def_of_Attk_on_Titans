using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour {

	public static int score;
	Text text;

	void Awake()
	{
		text = GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Update the score
		text.text = "Score: " + score;
	}
}
