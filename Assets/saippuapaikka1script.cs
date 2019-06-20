using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippuapaikka1script : MonoBehaviour
{
    public bool uusiLaatikkoPaikalla;
    // Start is called before the first frame update
    void Start()
    {
        uusiLaatikkoPaikalla = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "saippualaatikko")
            {
            uusiLaatikkoPaikalla = true;
            Debug.Log("uusiLaatikkoPaikalla = true");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "saippualaatikkotyhja")
        {
            uusiLaatikkoPaikalla = false;
            Debug.Log("uusiLaatikkoPaikalla = false");
        }
    }
}
