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
        //UpdateCounter();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCounter();
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
