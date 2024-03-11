using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    CreateBalloon createBalon;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exitButon()
    {
        Application.Quit();
    }
    public void playAgainButon()
    {
        SceneManager.LoadScene("Main");
    }
   
    
    
}
