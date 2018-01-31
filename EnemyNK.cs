using UnityEngine;
using System.Collections;

public class EnemyNK : MonoBehaviour {

	float lifeNK = 5;		//the health of this enemy
	public float speed = 3.0f;		//the moving speed of this enemy
	bool shouldmove = true;		//to set the condition of movement

	// Use this for initialization
	void Start ()
	{

	}

	void OnCollisionEnter (Collision col)
	{
		//If collide with wall
		if (col.gameObject.tag == "Walls") 
		{
			//Stop moving
			shouldmove = false;
		} 

		//If collide with cannon ball
		if (col.gameObject.tag == "CannonBall") 
		{
			//Decrease health
			lifeNK--;
		}
	}


	void FixedUpdate () 
	{
		//If health less or equal to 0
		if (lifeNK <= 0) 
		{
			//Destroy ifself
			Destroy (gameObject);
			//Increase score
			Scoring.score +=10;
		}

		//If can move
		if (shouldmove == true) 
		{
			//move
			transform.Translate (Vector3.left * Time.deltaTime * speed);
		}

	}
}