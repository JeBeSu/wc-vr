using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippuasarana : MonoBehaviour
{
    public bool aukee = false;
    float asentoz;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Aukaisu()
    {
        /* if(aukee == true && transform.localRotation.eulerAngles.z < 100)
         {
             transform.Rotate(0, 0, 1);
         }*/
        asentoz = transform.localRotation.eulerAngles.z;
        if (asentoz < 100)
        {
            transform.Rotate(0, 0, 1f);
        }

    }
    void Sulku()
    {
        /* if (aukee == false && transform.localRotation.eulerAngles.z > 1)
         {
             transform.Rotate(0, 0, -0.5f);
         }*/
        asentoz = transform.localRotation.eulerAngles.z;
        if (asentoz > 1)
        {
            transform.Rotate(0, 0, -1f);
        }
    }

     private void OnTriggerEnter(Collider other)
     {
       /* Debug.Log("tagi: " + other.tag);
        if (other.tag == "luutu" && other.tag == "kasi")
        {
            aukee = false;

            Debug.Log("luutu ja käsi");
        }*/

        if (other.tag == "kasi")
         {
            aukee = true;
                
            Debug.Log("käsi käsi käsi käsi !");
         }
         
    }

}
