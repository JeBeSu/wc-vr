using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kansisaranakakkonen : MonoBehaviour
{
    //public bool kansiAuki;
    Vector3 alku;
    Vector3 kulma;
    Rigidbody rb;
    float alkuY;
    float alkuZ;
    public GameObject kansi;
    public GameObject istuinrengas;
    public GameObject istuin;
    private int osumat;
    public int ponttoLikaMaara;
    // public bool liatHarjattu = false;
    public int likaMaara = 0; //tata muuttujaa muutetaan scriptista ponttolika.cs
    public float viive = 2.0f;
    float kaynnistysAika = 0.0f;
    bool ajastinKaynnistetty = false;

    // Start is called before the first frame update
    void Start()
    {
      //  kansiAuki = false;
     //   alkuY = transform.eulerAngles.y;
       // alkuZ = transform.eulerAngles.z;
        //alku = transform.position;
        ponttoLikaMaara = GameObject.FindGameObjectsWithTag("ponttoLika").Length;
        osumat = 0;
    }

    // Update is called once per frame
   /* void Update()
    {
        transform.position = alku;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, alkuY, alkuZ);
        if (transform.eulerAngles.x > 200 && transform.eulerAngles.x < 270)
        {
            transform.Rotate(1, 0, 0);
        }
        if (transform.eulerAngles.x > 1 && transform.eulerAngles.x < 200)
        {
            transform.Rotate(-1, 0, 0);
        }

        if (transform.eulerAngles.x < -10)
        {
            kansiAuki = true;
        }
        else
        {
            kansiAuki = false; 
        }
    }*/
    void Update()
    {
         if (osumat == 1)
         {
              kansi.transform.localRotation = Quaternion.Euler(-180, -90, 90);
         }
         if (osumat == 2)
         {
            istuinrengas.transform.localRotation = Quaternion.Euler(-180, -90, 90);
         }
         if (osumat > 2 && likaMaara > 1)
          {
            float kulunutAika = 0f; 
            if (ajastinKaynnistetty == false)
            {
                ajastinKaynnistetty = true;
                kaynnistysAika = Time.time;
            }
            else
            {
                kulunutAika = Time.time - kaynnistysAika;
            }
            if (kulunutAika > viive)
            {
                 istuinrengas.transform.localRotation = Quaternion.Euler(-90, -90, 90);
                 kansi.transform.localRotation = Quaternion.Euler(-90, -90, 90);
            }

          }
    }

    private void OnTriggerEnter(Collider other)
    {
        //int likaMaaraTemp = GameObject.FindGameObjectsWithTag("ponttoLika").Length;

        if (other.gameObject.CompareTag("kasi"))
        {
            osumat++;
            Debug.Log("käsi osui kanteen "+ osumat);
        }

    }
}
