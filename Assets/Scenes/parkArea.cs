using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkArea : MonoBehaviour
{
    public GameObject car;
    public static bool first = false;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){

        first = true;
        print("first");
        
    }

    void OnTriggerExit(Collider other){

        first = false;
        print("left first");
        
    }
}
