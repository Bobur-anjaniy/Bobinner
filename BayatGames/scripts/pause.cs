using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
  
    
    public GameObject GameCant;
    public GameObject PauseMenu;
    public static bool GameIsPause = false;
   
    
   
    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void pause1 ()
    {
        GameCant.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Play ()
    {
        GameCant.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void restart ()
    {
        
        Scene scene = SceneManager.GetActiveScene();
        int ActiveScene = scene.buildIndex;
        Time.timeScale = 1f;
        // activ senani int ga o'tkizadi.(shartmas)
        GameObject.Find("charter").GetComponent<character>().cointdel();
        SceneManager.LoadScene(scene.buildIndex);
    }
    public void Home() {
        GameObject.Find("charter").GetComponent<character>().cointdel();
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
