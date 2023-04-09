using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstacalsScript : MonoBehaviour
{
   [SerializeField] private float speed;
    void Start()
    {
        
    }

 
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z <= -10)
        {
            Destroy(this.gameObject);
        }
    }
   
}//class
