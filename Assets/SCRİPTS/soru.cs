using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soru : MonoBehaviour
{


    // Start is called before the first frame update
    public bool pnl;
    public GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "soru") { 
            Destroy(temas.gameObject);
            pnl = !pnl;
        }
        if(pnl)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (!pnl)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Butoon()
    {
        pnl = false;
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
}
