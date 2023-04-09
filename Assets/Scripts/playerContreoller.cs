using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class playerContreoller : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isJump=false;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private GameObject explotionVfx;
   [SerializeField] private helthbarscript _helthbarscript;
    private int coinCount;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isJump)
        {
            //playerjump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
     private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //Instantiate(explotionVfx,transform.position,Quaternion.identity);
            isJump =false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            isJump =true;
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacals"))
        {
           
            SceneManager.LoadScene(0);
        }
        else if (other.gameObject.CompareTag("coin"))
        {
            
            coinup();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("circle"))
        {
            Instantiate(explotionVfx, transform.position, Quaternion.identity);
        }
        else if (other.gameObject.CompareTag("heart"))
        {
            _helthbarscript.helthbarValuveUp();
        }


    }
    private void coinup()
    {
        coinCount++;
        coinText.text=coinCount.ToString();
    }

    //class
}
