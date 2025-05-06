using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject hint7;
    public GameObject hint8;
    public GameObject hint9;

    public PlayerInteracts playerInteracts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteracts.npcSpoken1 == true)
        {
            hint8.SetActive(false);
        }
        if (playerInteracts.npcSpoken2 == true)
        {
            hint5.SetActive(false);
        }
        if (playerInteracts.npcSpoken3 == true)
        {
            hint9.SetActive(false);
        }
        if (playerInteracts.npcSpoken4 == true)
        {
            hint6.SetActive(false);
        }
        if (playerInteracts.npcSpoken5 == true)
        {
            hint3.SetActive(false);
        }
        if (playerInteracts.npcSpoken6 == true)
        {
            hint2.SetActive(false);
        }
        if (playerInteracts.npcSpoken7 == true)
        {
            hint1.SetActive(false);
        }
        if (playerInteracts.npcSpoken8 == true)
        {
            hint4.SetActive(false);
        }
        if (playerInteracts.npcSpoken9 == true)
        {
            hint7.SetActive(false);
        }
    }
}
