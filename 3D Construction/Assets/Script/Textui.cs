using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Textui : MonoBehaviour
{
     public TextMeshProUGUI Worker;
     public TextMeshProUGUI Super;
    public TextMeshProUGUI Worker1;
    public TextMeshProUGUI Super1;
    // public GameObject Worker;
    // public GameObject sup;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(textflow());
        StartCoroutine(nexttextflow());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator textflow()
    {
       
        // sup.GetComponent<TextMeshPro>().text = "hi";
        
 

        yield return new WaitForSeconds(2f);
        Worker.text = "You have to increase my wages otherwise I won't work";

        yield return new WaitForSeconds(2f);
        Super.text = "I'am paying the base pay according to the current market scenario";

        yield return new WaitForSeconds(2f);
        Worker.text = "But I'm working more than Eight hours but i Won't get any remuneration";

        yield return new WaitForSeconds(2f);
        Super.text = "Everyone is doing the same job I can't be prtial";

        StartCoroutine(textflow());
    }
    IEnumerator nexttextflow()
    {
      
        yield return new WaitForSeconds(2f);
        Super1.text = "What do you doing? you don't have work today";

        yield return new WaitForSeconds(1f);
        Worker1.text = "I hate this uncertain working condition";

        yield return new WaitForSeconds(2f);
        Super1.text = "I can understand but uncertain work conditions are beyond our control";

        yield return new WaitForSeconds(2f);
        Worker1.text = " I acknowledge that unexpected changes can happen,but it's crucial to maintain effective communication";

        yield return new WaitForSeconds(2f);
        Worker1.text = " Without proper notice,we're unable to plan our personal lives";

        StartCoroutine(nexttextflow()); 
    }
}
