using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScreen : MonoBehaviour
{

    public QuitBox quitBox;

    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("NightClub", 0) != 0)
        {
            PlayerPrefs.SetInt("NightClub", 0);
        }
        quitBox.gameObject.SetActive(false);
    }
    public void PlayGame(){
        SceneManager.LoadScene("GameScene");
    }

    public void DisplayOptions(){
        SceneManager.LoadScene("optionScene");
    }

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            QuitGame();
        }
    }

    public void ConfirmQuit()
    {
        Application.Quit();
    }
    public void CancelQuit()
    {
        quitBox.gameObject.SetActive(false);
    }

    public void QuitGame(){
        quitBox.gameObject.SetActive(true);
    }
    public void DisplayGoogleStore()
    {
        SceneManager.LoadScene("googleScene");
    }
    public void SetNightClub(bool isNClub)
    {
        PlayerPrefs.SetInt("NightClub", (isNClub ? 1 : 0));
    }
}
