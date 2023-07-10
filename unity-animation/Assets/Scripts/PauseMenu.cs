using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public bool pauseGame;
    private void Start()
    {
        pauseGame = false;
        this.GetComponent<Canvas>().enabled = false;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    /// <summary>
    /// Pause: pauses the game
    /// </summary>
    public void Pause()
    {
        pauseGame = true;
        Time.timeScale = 0;
        this.GetComponent<Canvas>().enabled = true;
    }

    /// <summary>
    /// resume game after pause
    /// </summary>
    public void Resume()
    {
        pauseGame = false;
        Time.timeScale = 1;
        this.GetComponent<Canvas>().enabled = false;
    }

    /// <summary>
    /// Restart game
    /// </summary>
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// main menu
    /// </summary>
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// options menu
    /// </summary>
    public void Options()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Options");
    }
}
