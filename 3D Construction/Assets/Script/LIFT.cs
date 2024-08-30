using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LIFT : MonoBehaviour
{
    public GameObject lift;
    bool first;
    bool second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float dis = Vector3.Distance(transform.position, lift.transform.position);
        if (dis < 1.5f && first == true)
        {
            lift.transform.Translate(Vector3.forward * 1 * Time.deltaTime);
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
            if (transform.position.y > 7f)
            {
                first = false;
                // second = false;
            }
        }
        if (dis < 1.5f && second == true)
        {
            lift.transform.Translate(Vector3.up * 1 * Time.deltaTime);
            if (lift.transform.position.y > 9f)
            {
                second = false;
                first = false;
            }
        }
    }
   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "first")
        {
            Debug.Log("df");
            first = true;
        }
        if (other.gameObject.tag == "second")
        {
            second = true;
        }
    }*/
   public void First()
    {
        first = true;
    }
    public void Second()
    {
        second = true;
    }
}
