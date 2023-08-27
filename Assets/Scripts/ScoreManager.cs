using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//use updateScore to set highscore
//use GetScore to retreive highscore

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int highScore = 0;

    // write / read playerPref highScore
    private void Start ()
    {
        
        int countTmp = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = countTmp.ToString();
        Debug.Log(countTmp);
    }

    //public void AddScore(int toAdd) {

        
    //    highScore += toAdd;
    //    scoreText.text = highScore.ToString();
    //}

    public void UpdateScore(int newScore) {
        if (newScore < highScore)
        {
            PlayerPrefs.SetInt("highScore", newScore);
            highScore = newScore;
        }
    }

    public int GetScore()
    {
        return highScore;
    }

    public void WipeScore()
    {
        highScore= 0;
        PlayerPrefs.SetInt("highScore", 0);
    }

}
