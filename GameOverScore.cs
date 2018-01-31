using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text> ();
	}
	
	void Update()
	{
		//Update the final score
		text.text = "Your score: " + Scoring.score;
	}
}
