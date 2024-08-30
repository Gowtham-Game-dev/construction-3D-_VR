/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialouge : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] lines;
    public float speed;
    bool canTriggerCondition = false;
    float desiredDelayTime=10;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        text.text=string.Empty;
        startDialogue();
        // StartCoroutine(TriggerConditionAfterDelay());
        StartCoroutine(StartDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= desiredDelayTime) 
        {
            if (text.text == lines[index])
            {
               // StartCoroutine(delaytime());
               nextline();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];

            }
           // canTriggerCondition = false;
           
            
        }
       


    }
    void startDialogue() 
    {
        index = 0;
        StartCoroutine(typeline());
       
       
    }
    IEnumerator typeline()
    {
        foreach(char c in lines[index].ToCharArray()) 
        {
            text.text += c;
            yield return new WaitForSeconds(speed);
        }
    }
    void nextline()
    {
        if(index< lines.Length-1) 
        {
           // StartCoroutine(delay());
            index++;
            text.text = string.Empty;
            StartCoroutine(typeline()); 
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
        index++;

       *//* if (text.text == lines[index])
        {
            nextline();
        }
        else
        {
            StopAllCoroutines();
            text.text = lines[index];


        }
        StartCoroutine(delay());*//*
    }
    IEnumerator delaytime()
    {
        yield return new WaitForSeconds(10);
        nextline();
    }
    IEnumerator TriggerConditionAfterDelay()
    {
        yield return new WaitForSeconds(5);
        canTriggerCondition = true;

       
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(3);

        // Set the desired delay time after which the condition should be checked
        desiredDelayTime = Time.time + 10;
    }
}
*/
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialouge : MonoBehaviour
{
    /* public TextMeshProUGUI dialogueText;
     public float letterDelay = 0.1f;
     public float dialogueDelay = 1f;

     private string[] lines;
     private int currentIndex;
     private Coroutine currentCoroutine;

     void Start()
     {
         // Initialize your dialogue lines
         lines = new string[]
         {
             "Hello!",
             "How are you doing?",
             "This is a dynamic dialogue system.",
             "You can display text without using button conditions.",
             "It's pretty cool, isn't it?",
             "Enjoy!"
         };

         // Start the dialogue
         StartDialogue();
     }

     void StartDialogue()
     {
         currentIndex = 0;
         currentCoroutine = StartCoroutine(TypeDialogue(lines[currentIndex]));
     }

     IEnumerator TypeDialogue(string line)
     {
         dialogueText.text = "";

         foreach (char letter in line)
         {
             dialogueText.text += letter;
             yield return new WaitForSeconds(letterDelay);
         }

         currentCoroutine = null;
         yield return new WaitForSeconds(dialogueDelay);

         NextLine();
     }

     void NextLine()
     {
         currentIndex++;

         if (currentIndex < lines.Length)
         {
             currentCoroutine = StartCoroutine(TypeDialogue(lines[currentIndex]));
         }
         else
         {
             // Dialogue has ended
             EndDialogue();
         }
     }

     void EndDialogue()
     {
         // Perform any necessary actions or transitions after the dialogue ends
     }

     void SkipDialogue()
     {
         if (currentCoroutine != null)
         {
             StopCoroutine(currentCoroutine);
             currentCoroutine = null;
             dialogueText.text = lines[currentIndex];
             NextLine();
         }
     }

     void Update()
     {
         // Check for input to skip dialogue
         if (Input.GetKeyUp(KeyCode.Space))
         {
             SkipDialogue();
         }
     }*/
    public TextMeshProUGUI conversationText;
    public TextMeshProUGUI opsText;
    public float typingSpeed = 0.05f;
    public string[] conversationLines;
    public string[] opsconversationLines;
    public float conversationDelay = 2f;
    public float opsconversationDelay = 5f;

    private int currentLineIndex = 0;

    private void Start()
    {
        StartCoroutine(StartConversation());

        StartCoroutine(opsConversation());

        StartCoroutine(typetime());
    }

    private IEnumerator StartConversation()
    {
        foreach (string line in conversationLines)
        {
            yield return StartCoroutine(TypeLine(line));
            yield return new WaitForSeconds(conversationDelay);
        }

        // Conversation ends
        // Debug.Log("Conversation ended.");
        StartCoroutine(StartConversation());
    }
    private IEnumerator opsConversation()
    {
        foreach (string line in opsconversationLines)
        {
            yield return StartCoroutine(opsTypeLine(line));
            yield return new WaitForSeconds(opsconversationDelay);
        }

        // Conversation ends
        // Debug.Log("Conversation ended.");
        StartCoroutine(opsConversation());
    }

    private IEnumerator TypeLine(string line)
    {
        conversationText.text = "";
        

        foreach (char c in line)
        {
            conversationText.text += c;
            
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    private IEnumerator opsTypeLine(string line)
    {
       
        opsText.text = "";

        foreach (char c in line)
        {
           
            opsText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    IEnumerator typetime()
    {
        yield return new WaitForSeconds(5);
        StartConversation();
        yield return new WaitForSeconds(5);
        opsConversation();
        yield return new WaitForSeconds(5);
        StartConversation();
        yield return new WaitForSeconds(5);
        opsConversation();
        yield return new WaitForSeconds(5);
        StartConversation();
        yield return new WaitForSeconds(5);
        opsConversation();


        StartCoroutine(typetime());
    }

}
