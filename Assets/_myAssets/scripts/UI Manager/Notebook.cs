using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    public GameObject notebook;

    public GameObject pageOne;

    public GameObject pageTwo;

    public GameObject turnForward;

    public GameObject turnBack;

    public PlayerInteracts playerIt;

    public GameObject gray1;
    public GameObject gray2;
    public GameObject gray3;
    public GameObject gray4;
    public GameObject gray5;
    public GameObject gray6;
    public GameObject gray7;
    public GameObject gray8;
    public GameObject gray9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNotebook()
    {
        notebook.SetActive(true);
    }

    public void ExitNotebook()
    {
        notebook.SetActive(false);
    }

    public void TurnPageForward()
    {
        pageOne.SetActive(false);
        pageTwo.SetActive(true);
    }

    public void TurnpageBackward()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);
    }
}
