using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helthbarscript : MonoBehaviour
{
    [SerializeField] private Slider helthbar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sliderDescrease());
        helthbar.value = 100;
        helthbar.maxValue = 100; helthbar.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator sliderDescrease()
    {
        while (true)
        {   
            yield return new WaitForSeconds(1);
            helthbar.value = helthbar.value - 2;
        }
    }
    public void helthbarValuveUp()
    {

        helthbar.value = helthbar.value + 15;
    }
}//class
