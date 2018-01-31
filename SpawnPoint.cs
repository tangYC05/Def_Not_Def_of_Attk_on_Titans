using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	public GameObject EnemyGK, EnemyAK, EnemyNK;					//The enemies
	public GameObject spawnPointAK, spawnPointNK, spawnPointGK;		//The spawn points
	int maxCount = 1;
	int count = 0;

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		//to ensure spawn only one enemy at a time
		if( count < maxCount)
		{
			//Repeat spawning for every n second
			InvokeRepeating("EnemySpawn", 0.0f, 2.0f);
			count++;
		}

	}

	void EnemySpawn ()
	{
		//Random generate number between 0 to 10
		int Rand = Random.Range(0, 10);

		//spawn enemy if the number generated is the same
		if (Rand == 9) 
		{
			//Spawn an enemy at a spawn point
			Instantiate (EnemyAK, spawnPointAK.transform.position, spawnPointAK.transform.rotation);
		}

		else if(Rand == 8) 
		{
			//Spawn an enemy at another spawn point
			Instantiate (EnemyGK, spawnPointGK.transform.position, spawnPointGK.transform.rotation);
		}
		else
		{
			//Spawn an enemy at another spawn point
			Instantiate (EnemyNK,spawnPointNK.transform.position,spawnPointNK.transform.rotation);
		}
	}
}
