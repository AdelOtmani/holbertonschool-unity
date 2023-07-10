using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class for WinCanvas utility
public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Open main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void Next()
    {

        Scene level = SceneManager.GetActiveScene();

        if (level.name == "Level01")
        {
            SceneManager.LoadScene("Level02");
        }
        else if (level.name == "Level02")
        {
            SceneManager.LoadScene("Level03");
        }
        else
        {
            MainMenu();
        }
    }
}
