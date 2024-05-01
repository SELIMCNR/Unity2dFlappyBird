using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class harelet : MonoBehaviour
{
    public float Hiz;
    public float ziplamaGucu;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Hiz * Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);

        }

    }
  
    
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "levelgec")
        {
           // Destroy(gameObject);
            temas.gameObject.transform.parent.root.gameObject.GetComponent<gecis>().temas = true;
        }
    }
}
