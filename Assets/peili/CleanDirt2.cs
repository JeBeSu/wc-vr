using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanDirt2 : MonoBehaviour
{
    public int currentTexture;
    Renderer munRenderer;

    private int osumat;


    // Start is called before the first frame update
    void Start()
    {
        munRenderer = GetComponent<Renderer>();
        osumat = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (osumat < 2)
        {
            munRenderer.material.mainTexture = Resources.Load("Lika2") as Texture;
        }
        if (osumat < 1)
        {
            munRenderer.material.mainTexture = Resources.Load("Lika1") as Texture;
        }
        if (osumat < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("luutu"))
        {
            osumat--;
            
        }
        
    }
}
