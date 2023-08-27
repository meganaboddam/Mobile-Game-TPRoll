using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class feedbackScene : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backToSettings(){
        SceneManager.LoadScene("OptionScene");
    }
    public void toFeedBackScene(){
        SceneManager.LoadScene("FeedbackScene");
    }
}
