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
