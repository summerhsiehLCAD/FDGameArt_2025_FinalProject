using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public PlayerInteracts playerIt;
    public ScoreCounter scoreCount;

    int initialScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerIt = FindObjectOfType<PlayerInteracts>();

        if (scoreCount == null)
        {
            Debug.LogError("No ScoreManager");
        }
    }

    public void ScoreIncrease()
    {

        initialScore++;

        scoreCount.SetScore(initialScore);
    }
   
}
