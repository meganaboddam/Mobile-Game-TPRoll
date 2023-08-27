using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(checkTutorialStatus()){
            // tutorial
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // true:not completed
    // false:completed
    bool checkTutorialStatus(){
        // Set the tutorial status in Game Scene
        // Check the status
        int tutorialStatus = PlayerPrefs.GetInt("tutorial");
        return tutorialStatus == 0 ? true : false;
    }

}
