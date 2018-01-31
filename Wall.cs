using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Wall : MonoBehaviour {


	int castleHp = 200;
	float NKtimer = 0; 
	float GKtimer = 0;
	float damageTimeIntervalNK = 2;
	float damageTimeIntervalGK = 4;
	int EnemyAKdmg = 15;		//damage of enemy
	int EnemyNKdmg = 2; 		//damage of enemy
	int EnemyGKdmg = 30;		//damage of enemy

	// Use this for initialization
	void Start () 
	{
		
	}

	void OnCollisionEnter(Collision coll)
	{
		//If collide with layer named EnemyAK
		if (coll.collider.gameObject.layer == LayerMask.NameToLayer ("EnemyAK")) 
		{
			//damage is deal to wall
			castleHp = castleHp - EnemyAKdmg;
			//Update wall's health on UI
			CastleHp.castleHp -= EnemyAKdmg;
		}
	}

	void OnCollisionStay(Collision col)
	{
		//If staying in layer named EnemyNK
		if (col.collider.gameObject.layer == LayerMask.NameToLayer("EnemyNK"))
		{
			//If timer is more or equals to the continuous damaging interval
			if (NKtimer >= damageTimeIntervalNK) 
			{
				//Decrease the Timer
				NKtimer = NKtimer - damageTimeIntervalNK;
				//Deal damage to wall
				castleHp-= EnemyNKdmg;
				//Update wall's health at UI
				CastleHp.castleHp -= EnemyNKdmg;
				Debug.Log (castleHp);
			}
			//Start timer
			NKtimer = NKtimer + Time.deltaTime;
		} 

		//If staying in layer named EnemyGK
		if (col.collider.gameObject.layer == LayerMask.NameToLayer ("EnemyGK")) 
		{
			//If timer is more of equals to the continuous damaging interval
			if (GKtimer >= damageTimeIntervalGK) 
			{
				//Decrease the timer
				GKtimer = GKtimer - damageTimeIntervalGK;
				//Deal damage to wall
				castleHp -= EnemyGKdmg;
				//Update wall's health at UI
				CastleHp.castleHp -= EnemyGKdmg;
			}
			//Start Timer
			GKtimer = GKtimer + Time.deltaTime;
		}
	}
		
	// Update is called once per frame
	void Update ()
	{
		//If castle health less or equals to 0
		if (castleHp <= 0) 
		{
			//Destroy itself
			Destroy (gameObject);
			//Load the game over scene
			SceneManager.LoadScene ("GameOver Scene");
		}
	}
}
