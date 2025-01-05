using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resume()
    {
        Time.timeScale = 1.0f;
        PauseGame.SetActive(false);
    }
    public void Replay(string scenename)
    {
        SceneManager.LoadScene(scenename);

        if( Time.timeScale < 1.0f ) Time.timeScale = 1.0f;  
    }

    public void GoMenu(string scenename)
    {
        SceneManager.LoadScene(scenename);

        if (Time.timeScale < 1.0f) Time.timeScale = 1.0f;
    }

    

    public void pause()
    {
        PauseGame.SetActive(true);
        Time.timeScale = 0f;


    }
}
