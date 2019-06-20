using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vessapaperi1 : MonoBehaviour
{
    Rigidbody rb4;
    bool osui4 = false;
    public GameObject vessalaatikko;
    // Start is called before the first frame update
    void Start()
    {
        rb4 = GetComponent<Rigidbody>();
      //  vessalaatikko1 = new GameObject(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (osui4 == true)
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
             Debug.Log("osuneen nimi " + other.name);
            if (osui4 == false)
            {
                GameObject.Find("pistelaskija").GetComponent<pisteet>().tayttoPiste += 2;
            }
            osui4 = true;
            rb4.useGravity = false;
            rb4.drag = 100;
            rb4.angularDrag = 100;
        }
    }
}
