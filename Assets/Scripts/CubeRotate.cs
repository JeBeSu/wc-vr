using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public bool laatikonVoiKorvata = false;
    public bool laatikkoKorvattu = false;
    public bool doRotate = false;
    // public int pointsToAdd = 1;
    public float rotationSpeed = 45f;//135.0f;//Aseta editorissa makusi mukaan.
    float xRotation = -90f;
    public bool taskFinished = false;
    //public bool updatePoints = true;
    public GameObject laatikonPaikkaObject;//Asetetaan editorissa.
    private Transform taydenLaatikonPaikka;
    void Start()
    {
        taydenLaatikonPaikka = laatikonPaikkaObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (taskFinished == false)
        {
            if (doRotate == true)
            {
                if (laatikkoKorvattu == false)
                {
                    xRotation += Time.deltaTime * rotationSpeed;
                    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                    if (xRotation > 0f)
                    {
                        doRotate = false;
                        xRotation = 0f;
                    }
                }
                else
                {
                    xRotation -= Time.deltaTime * rotationSpeed;
                    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                    if (xRotation < -90f)
                    {
                        doRotate = false;
                        xRotation = -90f;
                        taskFinished = true;

                        /* Koska sailiomme on suljettu, tassa voisi tuhota tayden laatikon. 
                           Siihen tarvittaisiin taysi laatikko tallennettuna public Gameobject -muuttujaan..
                        */

                        //if (updatePoints == true) {
                        //    Points.instanssi.AddPoints(pointsToAdd);
                        //} else {
                        //    updatePoints = false;
                        //}
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kasi" && taskFinished == false)
        {
            doRotate = true;
        }

        if (other.tag == "TaysiLaatikko" && taskFinished == false && laatikonVoiKorvata == true)
        {
            /* Viestitetaan taydelle laatikolle, etta se voi siirtaa itsensa lopulliseen paikkaan. */
            GameObject.Find(other.name).GetComponent<BoxReplace>().taydenLaatikonPaikka = taydenLaatikonPaikka.transform;
            /* Alustetaan taysi laatikko ennen liikuttamista liikuttamisen alkutilan Transformilla.*/
            GameObject.Find(other.name).GetComponent<BoxReplace>().InitMovement(GameObject.Find(other.name).GetComponent<Transform>());
            GameObject.Find(other.name).GetComponent<BoxReplace>().voitSiirtya = true;

            laatikkoKorvattu = true;
            doRotate = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TyhjaLaatikko")
        {
            laatikonVoiKorvata = true;
        }
    }
}
