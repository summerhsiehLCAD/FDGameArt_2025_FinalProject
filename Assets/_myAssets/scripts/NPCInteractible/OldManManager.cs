using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManManager : MonoBehaviour
{
    public OldManDialogue omStart;

    public GameObject introDialogue;

    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject hint7;
    public GameObject hint8;
    public GameObject hint9;


    // Start is called before the first frame update
    void Start()
    {
      introDialogue.SetActive(true);
    }

    public void Hint1()
    {
        hint1.SetActive(true);
    }

    public void Hint2()
    {
        hint2.SetActive(true);
    }
    public void Hint3()
    {
        hint3.SetActive(true);
    }
    public void Hint4()
    {
        hint4.SetActive(true);
    }
    public void Hint5()
    {
        hint5.SetActive(true);
    }
    public void Hint6()
    {
        hint6.SetActive(true);
    }
    public void Hint7()
    {
        hint7.SetActive(true);
    }
    public void Hint8()
    {
        hint8.SetActive(true);
    }
    public void Hint9()
    {
        hint9.SetActive(true);
    }
}
