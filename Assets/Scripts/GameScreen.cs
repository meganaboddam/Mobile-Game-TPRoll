using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScreen : MonoBehaviour
{
    public TMP_Text tmpText;
    public PauseScreen pauseScreen;
    public DeathScreen deathScreen;
    public Timer timer;
    public int TotalPooCount;
    private bool death;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            PauseGame();
        }
        tmpText.text = TotalPooCount.ToString();
    }

    private void Start()
    {
        death = false;
        pauseScreen.gameObject.SetActive(false);
        TotalPooCount = 1;
    }

    public int GetTotalPoo()
    {
        return TotalPooCount;
    }
    public void SetTotalPoo(int n)
    {
        TotalPooCount = n;
    }


    public void PauseGame() {


        timer.TimerActive(false);
        //trun default offscreen on
        pauseScreen.gameObject.SetActive(true);


    }

    private void OnApplicationPause(bool pause)
    {
        PauseGame();
    }

    private void OnEnable()
    {
        timer.TimerActive(true);
    }
    private void OnDisable()
    {
        if (!death)
        {
            timer.TimerActive(false);
            //trun default offscreen on
            pauseScreen.gameObject.SetActive(true);
        }
    }

    

    public void OnPlayerDeath()
    {
        death = true;
        PlayerPrefs.SetInt("TotalDeath", 1 + 
                            PlayerPrefs.GetInt("TotalDeath", 0));
        Debug.Log("OnPlayDeathTotalDeath" + 
                            PlayerPrefs.GetInt("TotalDeath", 0));
        timer.TimerActive(false);
        gameObject.SetActive(false);
        deathScreen.gameObject.SetActive(true);

    }

}
