using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject FF;
    public GameObject MM;
    public GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(FF.transform.position,MM.transform.position)<0.1f)
        {
            lights.SetActive(true);
        }
        else lights.SetActive(false);
    }
}
