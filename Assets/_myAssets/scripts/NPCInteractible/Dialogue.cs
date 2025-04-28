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

    public int currentLine;

    public bool dialogueActive;

    // Start is called before the first frame update
    void Start()
    {

        dialogue.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {

        if (dialogueActive && Input.GetMouseButtonDown(0))
        {
            //dialogueBox.SetActive(false);
            //dialogueActive = false;

           // currentLine++;

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

       /* else if (currentLine >= lines.Length)
        {
            dialogueBox.SetActive(false);
            dialogueActive = false;

            currentLine = 0;
        }

        dialogue.text = lines[currentLine];*/
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
