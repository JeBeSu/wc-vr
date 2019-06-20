using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vessapaperi2 : MonoBehaviour
{
    Rigidbody rb3;
    bool osui3 = false;
    public GameObject vessalaatikko;

    // Start is called before the first frame update
    void Start()
    {
        rb3 = GetComponent<Rigidbody>();
        //vessalaatikko1 = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (osui3 == true)
        {
            transform.position = vessalaatikko.transform.position;
            transform.rotation = vessalaatikko.transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "vessapaperilaatikko")
        {
            vessalaatikko = GameObject.Find(other.name);
            Debug.Log("toinen osuneen nimi " + other.name);
            if (osui3 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
 

            osui3 = true;
            rb3.useGravity = false;
            rb3.drag = 100;
            rb3.angularDrag = 100;
        }
    }
}
