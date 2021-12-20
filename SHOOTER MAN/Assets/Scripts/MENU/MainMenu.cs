using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstlevel;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(firstlevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
