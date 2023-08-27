using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
    public Text LifeText;
    public Text PooText;
    public Text AppleText;
    private int countTmp;

    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {
        countTmp = PlayerPrefs.GetInt("TotalDeath", 0);
        
        Debug.Log("StatTotalDeath" + countTmp);
        LifeText.text = countTmp.ToString();
        countTmp = PlayerPrefs.GetInt("TotalPoo", 0);
        PooText.text = countTmp.ToString();
        countTmp = PlayerPrefs.GetInt("AppleEat", 0);
        AppleText.text = countTmp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
