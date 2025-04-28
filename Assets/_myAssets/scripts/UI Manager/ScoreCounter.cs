using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int scoreTracker;

    public TextMeshProUGUI scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Script how everytime the user interacts with an NPC, the score goes up
        UpdateCounter();
        //scoreTracker++;
    }

    void ScoreUP()
    {
        //if bla bla bla blu blu blue
        scoreTracker++;
    }

    void UpdateCounter()
    {
        scoreDisplay.text = scoreTracker.ToString() + " / 0 ";
    }
}
