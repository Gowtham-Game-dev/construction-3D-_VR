using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    public GameObject gascube;
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
        if(other.gameObject.tag=="firearea")
        {
            gascube.SetActive(true);   
        }
        if (other.gameObject.tag == "fire")
        {
          Destroy(other.gameObject,2);
            StartCoroutine(Warning());
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "area")
        {
            gascube.SetActive(false);
        }

    }
    IEnumerator Warning()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Fire Warning");
    }
}
