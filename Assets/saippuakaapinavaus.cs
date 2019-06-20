using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saippuakaapinavaus : MonoBehaviour
{
//  public GameObject sarana;
    public bool avaaja = false;

    void Start()
    {

    }

    void Update()
    {
        Debug.Log("avaaja updatessa " + avaaja);
        if (avaaja == true)
        {
            GetComponent<ovenavaus>().Avaus();
        }
        /*else (avaaja == false)
        {
            GetComponent<ovenavaus>().Sulkeminen();
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kasi")
        {
            avaaja = true;
        }

        /*  else
          {
              avaaja = false;
          }*/
    }

  /*private void OnTriggerExit(Collider other)
    {
        if (other.tag == "kasi")
        {
            avaaja = false;
        }
    }*/
}
