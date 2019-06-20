using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenavaus : MonoBehaviour
{
    float asentoy;
    float asentoTavoite;

    void Start()
    {
        asentoy = transform.eulerAngles.y;
        asentoTavoite = asentoy - 90f;
        Debug.Log("asento Y" + asentoy);
        Debug.Log("asento Tavoite" + asentoTavoite);
    }

    public void Avaus()
    {

        asentoy = transform.eulerAngles.y;
        Debug.Log("oven KULMA " + transform.eulerAngles.y);

        if (asentoy >= 270f && asentoy < 360f )//asentoTavoite)
        {
            transform.Rotate(0, -1f, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, asentoTavoite, 0);
            GetComponent<saippuakaapinavaus>().avaaja = false;
            Debug.Log("avaaja OVEN KULMA2 " + asentoy);
            // transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void Sulkeminen()
    {
        asentoy = transform.localRotation.eulerAngles.y;
        if (asentoy > 1)
        {
            transform.Rotate(0, 1f, 0);
        }
    }
}
