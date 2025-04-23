using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO.Pipes;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    
    public TextMeshProUGUI dialogue;

    public string[] lines;

    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {

        dialogue.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
       
        
        // Revise this area once raycast has been set up

        if (Input.GetMouseButtonDown(0))
        {
            if (dialogue.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopCoroutine("TypeLine");
                dialogue.text = lines[index];
                
            }
        }
    }

    void StartDialogue()
    {
        index = 0;

        StartCoroutine(TypeLine());
    }

    public IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogue.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogue.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueBox.SetActive(false);
        }
    }
}
