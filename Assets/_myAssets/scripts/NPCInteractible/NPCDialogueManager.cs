using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueManager : MonoBehaviour
{
    public List<GameObject> dBoxes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsDialogueActive()
    {
      
        foreach (GameObject dBox in dBoxes)
        {
            Dialogue dialogue = dBox.GetComponent<Dialogue>();
            if (dialogue != null)
            {
              //  Debug.Log($"Checking {dBox.name}: {dialogue.dialogueActive}");

                if (dialogue.dialogueActive == true)
                {
                    Debug.Log("Box is active");
                    return true;
                }
                else
                {
                    Debug.Log("Box is inactive");
                }
            }
        }

        return false;


    }
}
