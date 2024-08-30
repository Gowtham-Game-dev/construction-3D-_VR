using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject Instruction1;
    public GameObject Instruction2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Introstart");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Introstart()
    {
        yield return new WaitForSeconds(10);
        Instruction1.SetActive(true);

        yield return new WaitForSeconds(1);
        Instruction1.SetActive(false);

        yield return new WaitForSeconds(5);
        Instruction2.SetActive(true);

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Construction");
    }
    
}
