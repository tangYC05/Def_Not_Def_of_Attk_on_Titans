using UnityEngine;
using System.Collections;

public class EnemyAK : MonoBehaviour {
	
	float lifeAK = 8; 	//The health of this enemy
	public float speed = 20.0f;		//The speed of this enemy
	bool shouldmove = true;		//To set the condition of


	// Use this for initialization
	void Start ()
	{
		
	}
		
	void OnCollisionEnter (Collision col)
	{
		//If collide with cannon ball
		if (col.gameObject.tag == "CannonBall") 
		{
			//Decrease heath
			lifeAK--;
		}

		//If collide with wall
		if (col.gameObject.tag == "Walls") 
		{
			//stop moving
			shouldmove = false;
			//Destroy object
			Destroy (gameObject);
		}
	}
		
	// Update is called once per frame
	void FixedUpdate () 
	{
		//If health less or equal to 0
		if (lifeAK <= 0) 
		{
			//Destroy itself
			Destroy (gameObject);
			//Increase score
			Scoring.score += 20;
		}

		//If can move
		if(shouldmove == true)
		{
			//move
			transform.Translate(Vector3.left*Time.deltaTime*speed);
		}
	}
}
