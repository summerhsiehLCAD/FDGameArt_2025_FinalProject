using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Start : MonoBehaviour
{
    [SerializeField]
    private SceneController controller;
   
    
    public void StartGame()
    {
        Debug.Log("starting game");
        controller.LoadingScene("TestDemo_SP24");
    }
}
