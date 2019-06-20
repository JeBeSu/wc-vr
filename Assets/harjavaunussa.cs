using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harjavaunussa : MonoBehaviour
{
    Rigidbody rbharja;
    public bool harjapaikalla = true;
  //  public Transform rotaatio; 
    public Vector3 aloitusPaikka;
    // Start is called before the first frame update
    void Start()
    {
        harjapaikalla = true;
        rbharja = GetComponent<Rigidbody>();
        aloitusPaikka.x = transform.position.x;
        aloitusPaikka.y = transform.position.y;
        aloitusPaikka.z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (harjapaikalla == true)
        {
            transform.position = new Vector3(aloitusPaikka.x, aloitusPaikka.y, aloitusPaikka.z);// aloitusPaikka.transform.position.x;
            //transform.rotation = aloitusPaikka.transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "luutu-varsi")
        {
            harjapaikalla = true;
            other.transform.position = aloitusPaikka; // transform.position;
           // other.transform.rotation = aloitusPaikka; // transform.rotation;
            Debug.Log("harja siirretty paikalleen");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "luutu-varsi")
        {
            harjapaikalla = false;
            Debug.Log("harja siirretty pois");
        }
    }
}
