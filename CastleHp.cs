using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CastleHp : MonoBehaviour {

	public static int castleHp;
	Text castleHealthText;	

	void Awake () 
	{
		castleHealthText = GetComponent<Text> ();
		castleHp = 200;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Update the wall's health
		castleHealthText.text = "Castle Health: " + castleHp;
	}
}
