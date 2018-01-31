using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiBulletCount : MonoBehaviour {

	public static int multiBulletCount;
	Text multiBulletCountText;

	void Awake()
	{
		multiBulletCountText = GetComponent<Text> ();
		multiBulletCount = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Update the count
		multiBulletCountText.text = "Multi Shot left: " + multiBulletCount;
	}
}
