using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    OldManDialogue finishDialogue;

    [SerializeField]
    SceneController sceneController;

    //public GameObject endDialogueBox;

    public int scoreTracker;

    public TextMeshProUGUI scoreDisplay;

 

    // Start is called before the first frame update
    void Start()
    {
        UpdateCounter();
    }

    // Update is called once per frame
    void Update()
    {
        
        UpdateCounter();

        if (scoreTracker == 9)
        {
           

           // endDialogueBox.SetActive(true);

           // EndScreen();
        }
    }

    public void SetScore(int newScore)
    {
        scoreTracker = newScore;
        UpdateCounter();
    }

    public void UpdateCounter()
    {
        scoreDisplay.text = scoreTracker.ToString() + " / 9 ";
    }

  
}
