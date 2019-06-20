using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippualaatikkoscript : MonoBehaviour
{
    public bool saippuapaikka = false;
    public bool saippuapaikka2 = false;
    Rigidbody rbsl; //sl=saippualaatikko

    // Start is called before the first frame update
    void Start()
    {
        rbsl = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (saippuapaikka == true)
        {
            transform.position = GameObject.Find("saippuanpaikka").transform.position;
            transform.rotation = GameObject.Find("saippuanpaikka").transform.rotation;
        }
        if (saippuapaikka2 == true)
        {
            transform.position = GameObject.Find("saippuanpaikka2").transform.position;
            transform.rotation = GameObject.Find("saippuanpaikka2").transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "saippuanpaikka")
        {
            saippuapaikka = true;
            rbsl.useGravity = false;
            rbsl.drag = 100;
            rbsl.angularDrag = 100;
        }
        if (other.name == "saippuanpaikka2")
        {
            saippuapaikka2 = true;
            rbsl.useGravity = false;
            rbsl.drag = 100;
            rbsl.angularDrag = 100;
        }
    }
   /*private void OnTriggerExit(Collider other)
    {
        if (other.name == "saippuanpaikka")
        {
            saippuapaikka = false;
        }
        if (other.name == "saippuanpaikka2")
        {
            saippuapaikka2 = false;
        }
    }*/
}
