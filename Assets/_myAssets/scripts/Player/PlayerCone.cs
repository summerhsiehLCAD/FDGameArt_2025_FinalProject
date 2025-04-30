using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCone : MonoBehaviour
{
    public PlayerInteracts playerIt;

    // Start is called before the first frame update
    void Start()
    {
        playerIt = FindObjectOfType<PlayerInteracts>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by " + other.tag);

        if (other.gameObject.tag == "npc")
        {
            Debug.Log(other.gameObject.tag);
            playerIt.GetComponent<PlayerInteracts>().NPC1();
        }
        else if (other.gameObject.tag == "npc2")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC2();
        }
        else if (other.gameObject.tag == "npc3")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC3();
        }
        else if (other.gameObject.tag == "npc4")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC4();
        }
        else if (other.gameObject.tag == "npc5")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC5();
        }
        else if (other.gameObject.tag == "npc6")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC6();
        }
        else if (other.gameObject.tag == "npc7")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC7();
        }
        else if (other.gameObject.tag == "npc8")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC8();
        }
        else if (other.gameObject.tag == "npc9")
        {
            playerIt.GetComponent<PlayerInteracts>().NPC9();
        }
    }
}
