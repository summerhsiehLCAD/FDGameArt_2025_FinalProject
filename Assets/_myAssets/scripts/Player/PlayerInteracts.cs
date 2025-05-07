using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteracts : MonoBehaviour
{
    //Dialogue dialogueScript;

    public CollectionManager collectM;

    public GameObject playerCone;

    public GameObject dialogueBox1;
    public bool npcSpoken1 = false;

    public GameObject dialogueBox2;
    public bool npcSpoken2 = false;

    public GameObject dialogueBox3;
    public bool npcSpoken3 = false;

    public GameObject dialogueBox4;
    public bool npcSpoken4 = false;

    public GameObject dialogueBox5;
    public bool npcSpoken5 = false;

    public GameObject dialogueBox6;
    public bool npcSpoken6 = false;

    public GameObject dialogueBox7;
    public bool npcSpoken7 = false;

    public GameObject dialogueBox8;
    public bool npcSpoken8 = false;

    public GameObject dialogueBox9;
    public bool npcSpoken9 = false;

    public GameObject raycastOrigin;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerCone.SetActive(true);
        }
        else
        {
            playerCone.SetActive(false);
        }

       /* if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(raycastOrigin.transform.position, raycastOrigin.transform.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);

                if (hit.collider.gameObject.tag == "npc")
                {
                    NPC1();
                }
                else if(hit.collider.gameObject.tag == "npc2")
                {
                    NPC2();
                }
                else if (hit.collider.gameObject.tag == "npc3")
                {
                    NPC3();
                }
                else if (hit.collider.gameObject.tag == "npc4")
                {
                    NPC4();
                }
                else if (hit.collider.gameObject.tag == "npc5")
                {
                    NPC5();
                }
                else if (hit.collider.gameObject.tag == "npc6")
                {
                    NPC6();
                }
                else if (hit.collider.gameObject.tag == "npc7")
                {
                    NPC7();
                }
                else if (hit.collider.gameObject.tag == "npc8")
                {
                    NPC8();
                }
                else if (hit.collider.gameObject.tag == "npc9")
                {
                    NPC9();
                }
            }

        }*/
    }
    

    public void NPC1()
    {
        Debug.Log("NPC1 Talking");
        dialogueBox1.SetActive(true);
        if (npcSpoken1 == false)
        {
            
            collectM.ScoreIncrease();
            npcSpoken1 = true;
        }
    }

    public void NPC2()
    {
        Debug.Log("NPC2 Talking");
        dialogueBox2.SetActive(true);
        if (npcSpoken2 == false)
        {
            collectM.ScoreIncrease();
            npcSpoken2 = true;
        }
    }

    public void NPC3()
    {
        Debug.Log("NPC3 Talking");
        dialogueBox3.SetActive(true);
        if (npcSpoken3 == false)
        {
            npcSpoken3 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC4()
    {
        Debug.Log("NPC4 Talking");
        dialogueBox4.SetActive(true);
        if (npcSpoken4 == false)
        {
            npcSpoken4 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC5()
    {
        Debug.Log("NPC5 Talking");
        dialogueBox5.SetActive(true);
        if (npcSpoken5 == false)
        {
            npcSpoken5 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC6()
    {
        Debug.Log("NPC6 Talking");
        dialogueBox6.SetActive(true);
        if (npcSpoken6 == false)
        {
            npcSpoken6 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC7()
    {
        Debug.Log("NPC7 Talking");
        dialogueBox7.SetActive(true);
        if (npcSpoken7 == false)
        {
            npcSpoken7 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC8()
    {
        Debug.Log("NPC8 Talking");
        dialogueBox8.SetActive(true);
        if (npcSpoken8 == false)
        {
            npcSpoken8 = true;
            collectM.ScoreIncrease();
        }
    }

    public void NPC9()
    {
        Debug.Log("NPC9 Talking");
        dialogueBox9.SetActive(true);
        if (npcSpoken9 == false)
        {
            npcSpoken9 = true;
            collectM.ScoreIncrease();
        }
    }

    /*public void SetConditionTrue(int conditionIndex)
    {
        Debug.Log("Condition set to true");
        switch (conditionIndex)
        {
            case 1: if(!npcSpoken1) { npcSpoken1 = true; OnConditionMet?.Invoke(conditionIndex); } break;
        }*/
    }
