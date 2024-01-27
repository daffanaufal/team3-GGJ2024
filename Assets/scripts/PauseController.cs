using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    GameObject paused;

    bool isPaused;

    private void Start()
    {
        paused.SetActive(false);
    }

    public void Pausing()
    {
        if (Input.GetKey(KeyCode.P))
        {
            paused.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        paused.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit()
    {

    }

    private void Update()
    {
        Pausing();
    }
}
