using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text textTimer;
    private float currrentTime;
    private int min;
    private int hr;
    string minute;
    string hour;
    private bool timerOn;
    // Start is called before the first frame update
    void Awake()
    {
        textTimer = GetComponent<Text>();
    }
    void Start()
    {
        currrentTime = 0;
        min = 0;
        minute = "00";
        timerOn = true;
    //Time.timeScale = 60;
}

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            currrentTime += Time.deltaTime;
        }

        string second = LeadingZero((int)currrentTime);
        if (currrentTime > 59) {
            currrentTime = 0;
            min++;
            minute = LeadingZero(min);
        }
        if (min > 59)
        {
            min = 0;
            hr++;
            hour = LeadingZero(hr);
        }
        if (hr == 0)
        {
            textTimer.text = minute + ":" + second; 
        }
        else {
            textTimer.text = hour + ":" + minute + ":" + second;
        }
    }
    public void TimerActive(bool tf)
    {
        timerOn = tf;
    }

    public bool GetTimerActive()
    {
        return timerOn;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
