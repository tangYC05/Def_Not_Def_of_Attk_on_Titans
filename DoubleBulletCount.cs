using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoubleBulletCount : MonoBehaviour {

	public static int doubleBulletCount;
	Text doubleBulletCountText;

	void Awake()
	{
		doubleBulletCountText = GetComponent<Text> ();
		doubleBulletCount = 20;
	}

	// Update is called once per frame
	void Update () 
	{
		//Update the count left
		doubleBulletCountText.text = "Double Shot left: " + doubleBulletCount;
	}
}
