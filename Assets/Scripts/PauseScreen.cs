using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public Timer timer;
    //awake called before starts
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            ResumeGame();
        }
    }

    public void ResumeGame() {
        gameObject.SetActive(false);
    }

    // Called when ever enable as active
    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
        timer.TimerActive(true);
    }
}
