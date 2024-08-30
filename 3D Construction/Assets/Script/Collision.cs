using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
   // public GameObject quality100;
    public GameObject Repair1;
    public GameObject quantity100;
    public GameObject wood;
    public GameObject quantity501;
    public Animator anim;
    public GameObject Note;
    /*public GameObject SaftyObject;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Repair")
        {
            Repair1.SetActive(true);
        }
        if (other.gameObject.tag == "Meterials")
        {
            quantity100.SetActive(true);

        }
        if (other.gameObject.tag == "quantity")
        {
            quantity501.SetActive(true);
        }
        /* if (other.gameObject.tag == "Quantity50")
         {
             quantity501 .SetActive(true);
         }
         if (other.gameObject.tag == "Notice")
         {
             Note.SetActive(true);
         }
         if (other.gameObject.tag == "safe")
         {
             SaftyObject.SetActive(true);
         }*/
        if (other.gameObject.tag == "Fall")
        {
            Destroy(wood.gameObject);

            GameObject.Find("Ch17_nonPBR (7)").GetComponent<Rigidbody>().useGravity = true;
            anim.SetTrigger("trigger");
            StartCoroutine(anima());
        }
        if (other.gameObject.tag == "mes")
        {
            SceneManager.LoadScene("Message");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Meterials")
        {
            quantity100.SetActive(false);
           
        }
        if (other.gameObject.tag == "Repair")
        {
            Repair1.SetActive(false);
        }
        if (other.gameObject.tag == "quantity")
        {
            quantity501.SetActive(false);
        }
        if (other.gameObject.tag == "Quantity50")
        {
            quantity501.SetActive(false);
        }
       
        /* if (other.gameObject.tag == "safe")
         {
             SaftyObject.SetActive(false);
         }
 */
    }
    IEnumerator anima()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetTrigger("trigger2");
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="mes")
        {
            SceneManager.LoadScene("Message");
        }
    }*/
}
