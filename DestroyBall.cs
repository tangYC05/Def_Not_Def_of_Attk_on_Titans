using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		//If collide with enemy, land and wall
		if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Land" || col.gameObject.tag == "Walls") 
		{
			//Destroy itself
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}
