using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class came : MonoBehaviour
{
    public GameObject bird1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new UnityEngine.Vector3(bird1.gameObject.transform.position.x, 0f, -10f);

    }
}
