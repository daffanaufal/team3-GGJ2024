using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private SceneName sceneName;
    
    public void ExitButton()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}
