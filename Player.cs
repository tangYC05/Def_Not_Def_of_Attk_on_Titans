using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float rotateSpeed = 2.0F;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//If press up
		if (Input.GetKey ("up")) 
		{
			//If the angle is less or equal to 300
			if (transform.eulerAngles.z <= 300) 
			{
				//Rotate up
				transform.Rotate (Vector3.forward, rotateSpeed);
			}
		}


		//If press down
		if (Input.GetKey ("down")) 
		{
			//If the angle is more or equal to 186
			if (transform.eulerAngles.z >= 186) 
			{
				//Rotate down
				transform.Rotate (Vector3.back, rotateSpeed);
			}
		}
	}
}
	