using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroInfo1 : MonoBehaviour
{
    public int currentTexture; // Asetetaan tekstuuri
    Renderer munRenderer; // Haetaan renderi
    public int ohjeVaihto = 0;

    //private int osumat; // Julkistetaan osumat


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        //osumat = 8;// Osumien/pisteiden kokonaismäärä alussa
        munRenderer.material.mainTexture = Resources.Load("Ohje1") as Texture;
    }


    private void OnTriggerEnter(Collider other)  // Osuminen collideriin

    {
        if (other.gameObject.tag == "kasi") //tagin omistava objekti saa osuessaan toiminnan tapahtumaan
        {
            if (ohjeVaihto == 0)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje1") as Texture;  
            }
            if (ohjeVaihto == 1)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje2") as Texture;
            }
            if (ohjeVaihto == 2)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje3") as Texture;
            }
            if (ohjeVaihto == 3)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje4") as Texture;
            }
            if (ohjeVaihto == 4)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje5") as Texture;
            }
            if (ohjeVaihto == 5)
            {
                munRenderer.material.mainTexture = Resources.Load("Ohje6") as Texture;
            }
            ohjeVaihto++;
            if (ohjeVaihto == 6)
            {
                ohjeVaihto = 0;
            }

        }
    }

   /* private void OnTriggerExit(Collider other)  // Irtoaminen colliderista

    {
        if (other.gameObject.CompareTag("kasi")) //tagin omistava objekti saa irrotessaan toiminnan tapahtumaan
        {
            munRenderer.material.mainTexture = Resources.Load("1") as Texture;  

        }
    }*/
}
