using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vessanveto : MonoBehaviour
{
    public GameObject Poop1;
    public GameObject Poop2;
    //bool veto = false;
    AudioSource aani;
    public bool vessaHuuhdeltu = false;

    // Start is called before the first frame update
    void Start()
    {
        aani = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kasi")
        {
            aani.Play();
            //veto = true;
            Debug.Log("käsi osui nappiin");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "kasi")
        {
            Debug.Log("vessa huuhdeltu " + vessaHuuhdeltu);
            if (vessaHuuhdeltu == false)
            {
               // veto = false;
                Poop1.transform.position = new Vector3(-2.8f, -0.7f, 2.7f);
                Poop2.transform.position = new Vector3(-2.8f, -0.7f, 2.7f);
                Debug.Log("poop gone");
                int points = GameObject.Find("pistelaskija").GetComponent<pisteet>().eritelikaPiste;
                Debug.Log("points " + points);
                GameObject.Find("pistelaskija").GetComponent<pisteet>().eritelikaPiste -= 1;
                vessaHuuhdeltu = true;
            }
        }
    }
}
