using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.UI;

public class gameMangerScripts : MonoBehaviour
{
    [SerializeField] GameObject obstacls;
    [SerializeField] Transform spwnPotion;
    [SerializeField] private float maxtime;
    [SerializeField] private float mintime;
    [SerializeField] private float maxtimeToCoin;
    [SerializeField] private TextMeshProUGUI scroeText;
    [SerializeField] private GameObject playBotten;
    public GameObject player;
    public GameObject coinObj;
    [SerializeField] private int Score;
    public Transform trasformcoinpotion;
     private bool isPaused = true;
    [SerializeField] private GameObject pausePanal;
    private float levalupPointWaitTime;
    [SerializeField] private GameObject levalupPoints;
    private float heatspwanerTime;
    [SerializeField] private GameObject heart;
    

    //timer

    [SerializeField] private TextMeshProUGUI countdowndesplay; 

    private void FixedUpdate()
    {
        
    }

    void score()
    {
        Score++;
        scroeText.text=Score.ToString();
    }
    IEnumerator spawnObstacals()
    {
        while (true)
        {
            float waittime = Random.Range(mintime,maxtime);
            yield return new WaitForSeconds(waittime);
            Instantiate(obstacls,transform.position,Quaternion.identity);
        }
    }
    IEnumerator spawnCoin()
    {
        while (true)
        {
            float coinWaitTime=Random.Range(mintime,maxtimeToCoin);
            yield return new WaitForSeconds(coinWaitTime);
            Instantiate(coinObj,trasformcoinpotion.position,Quaternion.identity);
        }
    }
    IEnumerator spawnLevelupPuoints()
    {
        while (true)
        {
            levalupPointWaitTime = Random.Range(10, 15);
            yield return new WaitForSeconds(levalupPointWaitTime);
            Instantiate(levalupPoints, transform.position, Quaternion.identity);
        }
    }
    IEnumerator heartspwaner()
    {
        while (true)
        {
            heatspwanerTime= Random.Range(5,6);
            yield return new WaitForSeconds(heatspwanerTime);
            Instantiate(heart, trasformcoinpotion.position, Quaternion.identity);
        }
    }
    public void GameStart()
    {
        player.SetActive(true);
        StartCoroutine(spawnObstacals());
        StartCoroutine(spawnCoin());
        StartCoroutine(spawnLevelupPuoints());
        StartCoroutine(heartspwaner());
        InvokeRepeating("score", 0.5f, 0.1f);
    }public void gameQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void TogglePause()
    {
        

        if (isPaused)
        {
            Time.timeScale = 0; // Set time scale to 0 to pause the game
            pausePanal.SetActive(true);
        }
      
    }
    public void TogglePlay() {
        Time.timeScale = 1;
        StartCoroutine(CountDowntimerStart());
        
    } 
  /* public void timer()
    {
        print("jhefk");
        if (countDownTime> 0)
        {
            countdowndesplay.text = countDownTime.ToString();
            countDownTime--; }
        if (countDownTime == 0)
        {
            countdowndesplay.text = "GO";
            countDownTime--;
        }
        else if(countDownTime <0)
        {
            Time.timeScale = 1;
        }
        
    }
    */
    
    IEnumerator CountDowntimerStart()
    { int countDownTime = 3;
   
       while(countDownTime>0) 
        {
            
            yield return new WaitForSeconds(3);
            countDownTime--;
            countdowndesplay.text = "GO";
            Time.timeScale = 1;
            Debug.Log(countDownTime);
        }
   
    }
}//class
