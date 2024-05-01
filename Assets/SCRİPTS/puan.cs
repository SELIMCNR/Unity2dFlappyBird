using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puan : MonoBehaviour
{

    public float deger;
    public Text Puan1;
    public int hamPuan = 5;

    // Start is called before the first frame update
    void Start()
    {
        hamPuan = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Puan1.text = deger.ToString("f0");
       
    }
    public void puanartýr()
    {
        deger+=5;
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "gec")
        {
            Destroy(temas.gameObject);
            deger++;
        }        
    }
}
