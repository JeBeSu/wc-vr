using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanskanvaihtoscript : MonoBehaviour
{
    public Color aloitusVari ; //aloitus hanskan väri
    public Color vaihdetunHanskanVari;
    AudioSource aani;
    GameObject kasi;
    int vaihto;
    public bool hanskatKadessa = false;

    private void Start()
    {
        aani = GetComponent<AudioSource>();
        //vaihdetunHanskanVari = new Color(255f, 0f, 255f, 1.0f);
        //aloitusVari = new Color(0f, 255f, 99f, 1.0f);
        kasi = GameObject.FindWithTag("kasi");
        //vaihto = 2;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (hanskatKadessa = false)// && vaihto > 2)
        //{
            if (other.gameObject.tag == "kasi")
            {
                Debug.Log("käsi kävi");
                aani.Play();
                Renderer rend = other.GetComponent<Renderer>();
                rend.material.color = vaihdetunHanskanVari;
                kasi.GetComponent<Renderer>().material.color = vaihdetunHanskanVari;
            }

            hanskatKadessa = true;
            //gameObject.GetComponent<hanskatPoisScripti>().hanskatPoistettu = true;
        //}
    }
}
/*
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "kasi")
        {

            aani.Play();
            GameObject.Find("LeftHand").GetComponent<hanskatPoisScripti>().hanskaPois = false;

            Renderer rend = other.GetComponent<Renderer>();
            rend.material.color = vaihdetunHanskanVari;
        }
    }

}*/