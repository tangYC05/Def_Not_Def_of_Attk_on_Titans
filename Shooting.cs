using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	
	public GameObject bulletHole; 	 	//bullet hole object
	public GameObject Bullet; 			//bullet object
	public float BulletVelocity = 550; 	//bullet velocity
	int doubleShotCount = 20;			//Amount of double shot
	int multiShotCount = 10;			//Amount if multi shot
	float timer = 0;

	// Use this for initialization
	void Start () 
	{
	}

	void fireBullet()
	{
		//The Bullet instantiation
		GameObject Temporary_Bullet_Handler;
		Temporary_Bullet_Handler = Instantiate (Bullet, bulletHole.transform.position, bulletHole.transform.rotation) as GameObject;

		//Retrieve the Rigidbody component from the instantiated Bullet and control it.
		Rigidbody Temporary_RigidBody; 
		Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();

		//pushed the bullet forward
		Temporary_RigidBody.AddForce (transform.up * BulletVelocity);
	}

	void reloadDouble ()
	{
		//If double shot count less than 20
		if (doubleShotCount < 10) 
		{
			//Start timer
			timer = timer + Time.deltaTime;
			//If timer equalsor more than 2
			if (timer >= 2) 
			{
				//Increase one double shot
				doubleShotCount++;
				//Update count on UI
				DoubleBulletCount.doubleBulletCount++;
				//Reset timer
				timer = 0;
			}
		}
	}

	void reloadMulti()
	{
		//If multi shot count less than 10
		if (multiShotCount < 5) 
		{
			//Start timer
			timer = timer + Time.deltaTime;
			//When timer equals or more than 5
			if (timer >= 5) 
			{
				//Increase one multi shot
				multiShotCount++;
				//Update count on UI
				MultiBulletCount.multiBulletCount++;
				//Reset timer
				timer = 0;
			}
		}
	}
		
	// Update is called once per frame
	void FixedUpdate () 
	{
		//If press 'Z' button
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			//Fire one bullet
			fireBullet ();
		} 

		//If multi shot is more than 0
		if (multiShotCount > 0)
		{
			//If press 'C'
			if (Input.GetKeyDown (KeyCode.C)) 
			{
				//Fire the first bullet
				fireBullet ();
				//Delay of firing rest of the bullets
				Invoke("fireBullet", 0.05f);
				Invoke("fireBullet", 0.1f);
				Invoke("fireBullet", 0.15f);
				Invoke("fireBullet", 0.2f);
				Invoke("fireBullet", 0.25f);
				Invoke("fireBullet", 0.3f);
				Invoke("fireBullet", 0.35f);
				Invoke("fireBullet", 0.4f);
				//Multi shot count decrease
				multiShotCount--;
				//Update the multi shot count on UI
				MultiBulletCount.multiBulletCount--;
			}
		}

		//If double shot left is more than 0
		if (doubleShotCount > 0) 
		{
			//If press 'X' button
			if (Input.GetKeyDown (KeyCode.X)) 
			{
				//Fire one bullet
				fireBullet ();
				//Delay of fire second bullet
				Invoke ("fireBullet", 0.05f);
				//Double shot count decrease
				doubleShotCount--;
				//Update the double count on UI
				DoubleBulletCount.doubleBulletCount--;
			}
		}

		reloadDouble ();
		reloadMulti ();

	}
}

