using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManEnd : MonoBehaviour
{
    public List<GameObject> npcDiaBoxes;

    public ScoreCounter scoreCounter;

    public OldManManager oldManM;

    

   // public NPCDialogueManager dialogue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsNPCDialogueActive() == false && scoreCounter.scoreTracker == 9)
        {
            oldManM.EndDialogue();
        }
      
    }

    public bool IsNPCDialogueActive()
    {

        foreach (GameObject dBox in npcDiaBoxes)
        {
            Dialogue dialogue = dBox.GetComponent<Dialogue>();
            if (dialogue != null && dialogue.dialogueActive == true)
            {
                Debug.Log("Another NPC is talking");
                return true;
            }
        }

        Debug.Log("No NPC is talking)");
        return false;


    }

}
