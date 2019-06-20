using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ponttolika : MonoBehaviour
{
    public int currentTexture;
    Renderer minRenderer;
    public GameObject kansi;
    private int osumat;

    // Start is called before the first frame update
    void Start()
    {
        minRenderer = GetComponent<Renderer>();
        osumat = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (osumat < 2)
        {
            minRenderer.material.mainTexture = Resources.Load("Lika2") as Texture;
        }
        if (osumat < 1)
        {
            minRenderer.material.mainTexture = Resources.Load("Lika1") as Texture;
        }
        if (osumat < 0)
        {
            Destroy(gameObject);
            kansi.GetComponent<kansisaranakakkonen>().likaMaara++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("kakkaLuutu"))
        {
            osumat--;

        }

    }
}
