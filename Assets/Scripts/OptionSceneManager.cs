using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneManager : MonoBehaviour
{
    public StatsPanel statsPanel;
    public ErasePanel erasePanel;
    //public Toggle NCToggle;
    // Start is called before the first frame update
    // public Text text;
    void Start()
    {
        
        //open count
        int countTmp = PlayerPrefs.GetInt("openCount",0);
        PlayerPrefs.SetInt("openCount",++countTmp);
        Debug.Log("OpenOptionCount" + countTmp);

        //NCToggle = GetComponent<Toggle>();

        //Debug.Log(NCToggle);
        //if (NCToggle.isOn != (PlayerPrefs.GetInt("NightClub") != 0))
        //{
        //    NCToggle.SetIsOnWithoutNotify((PlayerPrefs.GetInt("NightClub") != 0));
        //}
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
    public void test(){
        SceneManager.LoadScene("MenuScene");
    }
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ShowStats()
    {
        statsPanel.gameObject.SetActive(true);
    }
    public void EraseSetting()
    {
        erasePanel.gameObject.SetActive(true);
    }


    //public void SetnightClub(bool isNClub)
    //{
    //    PlayerPrefs.SetInt("NightClub", (isNClub ? 1 : 0));
    //}

}
