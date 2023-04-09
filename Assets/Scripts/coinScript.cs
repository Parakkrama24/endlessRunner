using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    [SerializeField] private float rotationspeed;
    [SerializeField] private float speed;
    private Rigidbody rb;
 
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }


    void Update()
    {
        
       transform.Rotate(0,0,rotationspeed*Time.deltaTime);
        rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
        if (transform.position.z < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
