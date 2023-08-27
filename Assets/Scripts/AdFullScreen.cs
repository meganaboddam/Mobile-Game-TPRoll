using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdFullScreen : MonoBehaviour
{
    public int AdSec = 5;
    private float timer = 0.0f;
    //awake called before starts
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > AdSec) {
            gameObject.SetActive(false);
        }
    }

}
