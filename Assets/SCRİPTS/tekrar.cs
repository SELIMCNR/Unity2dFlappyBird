using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text yazi;
    public Text yazi2;
    public Text yazi3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        /*
        if(temas.gameObject.tag == "tekrar")
        {
           
            Application.LoadLevel(Application.loadedLevel);
        }*/
        if (temas.gameObject.tag == "soru")
        {
            yazi.text = "8 x 7 kaç eder ? ";
            yazi2.text = "56";
            yazi3.text = "26";

        }

       
        
    }
}
