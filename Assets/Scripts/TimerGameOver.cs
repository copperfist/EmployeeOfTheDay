using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerGameOver : MonoBehaviour
{
    int countDownStartValue = 10;
    public Text timerUI;
    void Start()
    {
        countDownTimer();
    }
    
    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue); 
            timerUI.text = spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f); 
        }else
        {
            FindObjectOfType<GameManager>().EndGame();
            timerUI.text = "Game Over";
            
        }

    }


}
