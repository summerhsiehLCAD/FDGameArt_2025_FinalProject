using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteracts : MonoBehaviour
{
    //Dialogue dialogueScript;

    public GameObject dialogueBox1;
    public GameObject dialogueBox2;

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
                }
                else if(hit.collider.gameObject.tag == "npc2")
                {
                    Debug.Log("NPC2 Talking");
                    dialogueBox2.SetActive(true);
                }
            }

        }
    }
}
