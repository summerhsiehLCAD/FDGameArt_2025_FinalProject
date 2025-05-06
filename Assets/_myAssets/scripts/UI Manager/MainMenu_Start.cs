using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Start : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene("TestDemo_SP24");
    }
}
