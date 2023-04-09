using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levalupPointScripts : MonoBehaviour
{[SerializeField] private float speed = -50f;

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}//class
