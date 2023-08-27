using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErasePanel : MonoBehaviour
{
    public Button button;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    public void SayNo() 
    {
        gameObject.SetActive(false);
    }
    public void EraseAll()
    {
        PlayerPrefs.DeleteAll();
        button.gameObject.SetActive(true);
    }
}
