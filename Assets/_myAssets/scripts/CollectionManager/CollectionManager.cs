using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public PlayerInteracts playerIt;
    public ScoreCounter scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        playerIt = FindObjectOfType<PlayerInteracts>();

        if (scoreCount == null)
        {
            Debug.LogError("No ScoreManager");
        }
    }

    // Update is called once per frame
    void Update()
    {
        int initialScore = 0;

        if (playerIt.npcSpoken1) initialScore++;
        if (playerIt.npcSpoken2) initialScore++;
        if (playerIt.npcSpoken3) initialScore++;
        if (playerIt.npcSpoken4) initialScore++;
        if (playerIt.npcSpoken5) initialScore++;
        if (playerIt.npcSpoken6) initialScore++;
        if (playerIt.npcSpoken7) initialScore++;
        if (playerIt.npcSpoken8) initialScore++;
        if (playerIt.npcSpoken9) initialScore++;

        scoreCount.SetScore(initialScore);

    }
   
}
