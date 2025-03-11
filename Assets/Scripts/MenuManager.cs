using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsPanel;
   
    
    public void StartGame(string sceneName)
    {
       
        SceneManager.LoadScene(sceneName);
    }

    public void ShowOtions(bool show)
    {
        optionsPanel.SetActive(show);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
