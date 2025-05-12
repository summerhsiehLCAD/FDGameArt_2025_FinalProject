using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public SceneController sceneController;

    public OldManDialogue oldManDia;

    void Update()
    {
       if (oldManDia.dialogueFinished == true)
        {
            EndingScreen();
        }
    }

    private void EndingScreen()
    {
        sceneController.LoadingScene("EndScreen");
        Time.timeScale = 1;
    }
}
