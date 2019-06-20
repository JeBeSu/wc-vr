using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harja : MonoBehaviour
{
    Rigidbody rbharja;
    public bool harjapaikalla = true;
  //  public Transform rotaatio; 
  //  public Vector3 paikka;
    // Start is called before the first frame update
    void Start()
    {
        harjapaikalla = false;
        rbharja = GetComponent<Rigidbody>();
       // paikka.x = transform.position.x;
      //  paikka.y = transform.position.y;
       //paikka.z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (harjapaikalla == true)
        {
            transform.position = GameObject.Find("harjanpaikka3").transform.position;
            transform.rotation = GameObject.Find("harjanpaikka3").transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "harjanpaikka3")
        {
            harjapaikalla = true;
          //  rbharja.useGravity = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {

    }
}
