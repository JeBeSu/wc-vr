using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxReplace : MonoBehaviour
{
    /*Muuttuja [voitSiirtya] asetetaan CubeRotate-skriptissa. Ei saa asettaa Unityn editorissa  manuaalisesti.*/
    public bool voitSiirtya = false;
    public Transform startTransform;

    /* taydenLaatikonpaikka alustetaan CubeRotate-skriptissa. Ei saa asettaa Unityn editorissa manuaalisesti.*/
    public Transform taydenLaatikonPaikka;
    public float moveMentSpeed = 1.0f;
    private float startTime;
    private float endTime;
    private float distanceOfTravel;
    //public Transform endTransform;



    void Start()
    {
        //Pakko alustaa aluksi jollain, CubeRotate-skripti paivittaa myohemmin.
        taydenLaatikonPaikka = GetComponent<Transform>();
    }

    /* Tata kutsutaan Cuberotate-skripista. Parametri on jonkin tayden laatikon Transform */
    public void InitMovement(Transform liikkeenAloitusTransform)
    {
        startTransform = liikkeenAloitusTransform;
        startTime = Time.time;
        distanceOfTravel = Vector3.Distance(startTransform.position, taydenLaatikonPaikka.position);
    }

    void Update()
    {
        if (voitSiirtya == true)
        {
            // Distance moved = time * speed.
            float distCovered = (Time.time - startTime) * moveMentSpeed;

            // Fraction of journey completed = current distance divided by total distance.
            float fracJourney = distCovered / distanceOfTravel;

            // Set our position as a fraction of the distance between the markers.
            /* Taysi laatikko kulkee pienen matkan sulavasti ja hyppaa sen jalkeen lopun matkan.
               Nain estetaan hairitsevat tutinat ja pyorimiset matkan lopussa ennen rotaatioiden lukitusta.
            */
            if (fracJourney < 0.1)
            {
                transform.position = Vector3.Lerp(startTransform.position, taydenLaatikonPaikka.position, fracJourney);
            }
            else
            {
                transform.position = taydenLaatikonPaikka.position;
                transform.rotation = taydenLaatikonPaikka.rotation;
                GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
    }
}