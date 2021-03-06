using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplaycontroller : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel;

    [SerializeField]
    private Button restartGameButton;

	public void PauseButton(Collider target)
	{

		if (target.gameObject.tag == "Enemy")
		{
			Time.timeScale = 0f;
			pausePanel.SetActive(true);
			restartGameButton.onClick.RemoveAllListeners();
			restartGameButton.onClick.AddListener(() => ResumeGame());
		}

		
	}

	public void GoToMenu()
	{
		Time.timeScale = 1f;
		Application.LoadLevel("MainMenu");
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive(false);
	}

	public void RestartGame()
	{
		Time.timeScale = 1f;
		Application.LoadLevel("Gameplay");
	}
}
