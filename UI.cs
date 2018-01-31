using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class UI : MonoBehaviour {

	public Button startText;
	public Button exitText;

	void Start()
	{
		startText = startText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
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