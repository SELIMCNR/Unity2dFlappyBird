using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecis : MonoBehaviour
{
    public GameObject Alan;
    public bool temas;

    // Start is called before the first frame update
    void Start()
    {
        temas = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(temas)
        {
            Invoke("IleriAtla", 3f);
            temas = false;
        }
    }

    void IleriAtla()
    {
        transform.position = transform.position = new Vector3(32,0,0);
    }
}
