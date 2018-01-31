using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverUI : MonoBehaviour {

	public Button PlayAgain;
	public Button Exit;

	// Use this for initialization
	void Start()
	{
		PlayAgain = PlayAgain.GetComponent<Button>();
		Exit = Exit.GetComponent<Button>();
	}
	
	public void StartGame()
	{
		//Load the game scene
		SceneManager.LoadScene ("Play Scene");
	}

	public void ExitGame()
	{
		//Exit the game
		Application.Quit();
	}
}
