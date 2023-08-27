using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperFan : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Timer timer;
    public float timeLeft;
    public Color targetColor;
    public Color blankColor;
    public AlphaChangeController alphaCtr;

    public float currentAlpha;

    //enable/disable timer;
    public float currrentTime;
    public float fanDuration = 7;
    public float disableStart = 3;


    private void Awake()
    {
        //gameObject.SetActive(false);
        timeLeft = fanDuration - disableStart;
        blankColor = new Color(1f, 1f, 1f, 0f);
        currentAlpha = GetComponent<Renderer>().material.color.a;
    }

    private void OnEnable()
    {
        currrentTime = 0;
    }
    private void OnDisable()
    {
        currrentTime = 0;
        alphaCtr.SetAlpha(1);
        timeLeft = fanDuration - disableStart;
        currentAlpha = GetComponent<Renderer>().material.color.a;
    }

    private void OnDestroy()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if (player.transform != null)
        {
            transform.position = player.transform.position + new Vector3(0, 0, -3);
            
        }

        transform.Rotate(Vector3.forward * (Random.Range(-520, -300) * Time.deltaTime));

        currrentTime += Time.deltaTime;
        //if (currrentTime > 3)
        //{
        //    //blanking state
        //
        //    alphaCtr.SetAlpha(1);
        //    //targetColor = gameObject.GetComponent<Renderer>().material.color;
        //    //gameObject.GetComponent<Renderer>().material.color = blankColor;
        //    
        //}
        if (currrentTime > disableStart && currrentTime < fanDuration)
        {
                
                currentAlpha = Mathf.MoveTowards(currentAlpha, 0.1f , Time.deltaTime / timeLeft);
                alphaCtr.SetAlpha((float)currentAlpha);
                timeLeft -= Time.deltaTime;
        }

            if (currrentTime > fanDuration)
        {

            gameObject.SetActive(false);
        }

     //   currentAlpha = Mathf.MoveTowards(currentAlpha, Random.Range(0f, 255), 2f * Time.deltaTime);
        
    }



}
