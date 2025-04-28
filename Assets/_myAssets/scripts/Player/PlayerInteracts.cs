using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteracts : MonoBehaviour
{
    //Dialogue dialogueScript;

    public GameObject dialogueBox1;
    public bool npcSpoken1;

    public GameObject dialogueBox2;
    public bool npcSpoken2;

    public GameObject dialogueBox3;
    public bool npcSpoken3;

    public GameObject dialogueBox4;
    public bool npcSpoken4;

    public GameObject dialogueBox5;
    public bool npcSpoken5;

    public GameObject dialogueBox6;
    public bool npcSpoken6;

    public GameObject dialogueBox7;
    public bool npcSpoken7;

    public GameObject dialogueBox8;
    public bool npcSpoken8;

    public GameObject dialogueBox9;
    public bool npcSpoken9;


    //public List<Dialogue> dialogues;

    public GameObject raycastOrigin;

    //public bool canInteract = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(raycastOrigin.transform.position, raycastOrigin.transform.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);

                if (hit.collider.gameObject.tag == "npc")
                {
                    //canInteract = true;
                    Debug.Log("NPC1 Talking");
                    dialogueBox1.SetActive(true);
                    npcSpoken1 = true;
                }
                else if(hit.collider.gameObject.tag == "npc2")
                {
                    Debug.Log("NPC2 Talking");
                    dialogueBox2.SetActive(true);
                    npcSpoken2 = true;
                }
            }

        }
    }
}
