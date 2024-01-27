using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private SceneName sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}
