using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using UnityEngine;


public class C : MonoBehaviour
{
    public float movespeed;
    
    // Start is called before the first frame update
    void Start()
    {
        movespeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime,0f,movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
