using UnityEngine;
using System.Collections;

public class EnemyGK: MonoBehaviour {

	int lifeGK = 50; 	//The health of this enemy
	public float speed = 1.0f; //The moving speed of this enemy
	bool shouldmove =  true; //To set the condition of movement

	// Use this for initialization
	void Start ()
	{

	}
		
	void OnCollisionEnter (Collision col)
	{
		//If collide with cannon ball
		if (col.gameObject.tag == "CannonBall") 
		{
			//Decrease health
			lifeGK--;
		}

		//If collide with wall
		if (col.gameObject.tag == "Walls") 
		{
			//Stop moving
			shouldmove = false;
		}
	}
			
	// Update is called once per frame
	void FixedUpdate ()
	{
		//If health less or equal to 0
		if (lifeGK <= 0) 
		{
			//Destroy itself
			Destroy (gameObject);
			//Increase score
			Scoring.score += 50;
		}
			
		//If can move
		if (shouldmove == true) 
		{
			//move
			transform.Translate (Vector3.left * Time.deltaTime * speed);
		}
	}
}