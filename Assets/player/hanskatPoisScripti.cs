using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanskatPoisScripti : MonoBehaviour
{
    public Color kumiHanska;
    private bool hanskaPois = false;
    public bool hanskatPoistettu = false;
    //AudioSource aani;

    // Start is called before the first frame update
    void Start()
    {
        hanskaPois = false;
        //aani = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<hanskanvaihtoscript>().hanskatKadessa = true)
        {
            if (other.tag == "kasi")// && hanskatPoistettu == false)
            {

                if (hanskaPois == false)
                {
                    GameObject.Find("kertsihanskaroska").transform.position = other.transform.position;
                    Renderer rend = other.GetComponent<Renderer>();
                    rend.material.color = kumiHanska;
                    Debug.Log("poipois!");
                    //hanskaPois = true;
                }
                else
                {
                    GameObject.Find("kertsihanskaroska").transform.position = other.transform.position;
                    Renderer rend = other.GetComponent<Renderer>();
                    rend.material.color = kumiHanska;
                    Debug.Log("toinenkin pois!");
                    hanskaPois = true;
                }
                hanskatPoistettu = true;

            }
        }
    }
    
}
