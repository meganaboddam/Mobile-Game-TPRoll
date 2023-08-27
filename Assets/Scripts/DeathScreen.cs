using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public AdFullScreen adScreen;
    private int deathCounter;
    public Text poopReport;
    public Spawner spn;
    public GameObject BackGround;
    public GameObject DeathFace;
    public GameScreen gameScreen;

    //AD control
    public int MinGameBeforeAd;


    private int CurPoo;
    public Timer timer;
    public float timeLeft;
    public Color targetColor;
    public bool NIGHTCLUB;
    private int Scoretemp;

    //awake called before starts
    private void Awake()
    {
        gameObject.SetActive(false);
        MinGameBeforeAd = 2;
        NIGHTCLUB = (PlayerPrefs.GetInt("NightClub") != 0);
        Debug.Log("NightClub " + PlayerPrefs.GetInt("NightClub"));
        //PlayerPrefs.SetInt("NightClub", (NIGHTCLUB ? 1 : 0));
    }
    // Called when ever enable as active
    private void OnEnable()
    {
        timer.TimerActive(false);
        DeathFace.SetActive(true);
        targetColor = new Color(0, 0, 0);
        Time.timeScale = 7;

        //get poo count, min = 1; update poo text and 
        CurPoo = gameScreen.GetTotalPoo();
        poopReport.text = CurPoo.ToString();

        //update highscore and total poo
        Scoretemp = PlayerPrefs.GetInt("highScore", 0);
        if (CurPoo > Scoretemp)
        {
            PlayerPrefs.SetInt("highScore", CurPoo);
        }
        Scoretemp = PlayerPrefs.GetInt("TotalPoo", 0);
        Scoretemp += CurPoo;
        PlayerPrefs.SetInt("TotalPoo", Scoretemp);

        deathCounter++;
    }

    private void Update()
    {
        //BackGround.GetComponent<Renderer>().material.color = targetColor;
   
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            BackGround.GetComponent<Renderer>().material.color = targetColor;

            // start a new transition
            // Color changes
            if (NIGHTCLUB)
            {
                targetColor = new Color(Random.value, Random.value, Random.value);
                timeLeft = 1.0f;
            }

        }
        else
        {
            // transition in progress
            // calculate interpolated color
            BackGround.GetComponent<Renderer>().material.color = 
                Color.Lerp(BackGround.GetComponent<Renderer>().material.color,
                targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
    private void OnDisable()
    {
        timer.TimerActive(true);
        DeathFace.SetActive(false);
        Time.timeScale = 1;
    }


    //reload the scene/level
    public void RestartGame()
    {
        checkAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        checkAd();
        SceneManager.LoadScene("MenuScene");
    }

    private void checkAd() {
        
        
        if (deathCounter > MinGameBeforeAd)
        {
            adScreen.gameObject.SetActive(true);
            deathCounter = 0;
        }
    }


}
