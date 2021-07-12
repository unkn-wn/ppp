using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkArea2 : MonoBehaviour
{
    public GameObject car;
    public static bool second = false;
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

        second = true;
        print("sec");
        
    }

    void OnTriggerExit(Collider other){

        second = false;
        print("left sec");
        
    }
}
