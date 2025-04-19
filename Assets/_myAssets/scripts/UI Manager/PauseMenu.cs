using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject pauseMenu;

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pauseMenu.SetActive(true);
            Debug.Log("Menu Activated");
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*public void Quit()
    {
        SceneManager.LoadScene("Home Menu");
    }*/
    //Make this active when you finish making the Home Menu Scene
}
