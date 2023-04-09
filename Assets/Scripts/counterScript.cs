using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counterScript : MonoBehaviour
{
    public int maxcount = 3;
    public TMP_Text text_;
public void counetr()
    {
        StartCoroutine(startcounetr());
    }

    IEnumerator startcounetr()
    {
        while (maxcount > 0)
        {
            text_.text=maxcount.ToString();
           
            yield return new WaitForSeconds(1);
            maxcount--;
        }
        text_.text = "GO";
        Time.timeScale = 1;
    }
}//class