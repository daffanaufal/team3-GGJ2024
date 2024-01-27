using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScriptScene : MonoBehaviour
{
    public TextMeshProUGUI FinalScore, FinalTime;
    public GameObject WinUI;
    public GameObject[] locks;
    public bool isFinished;
    public GameObject gembok;


    private void Start()
    {
        if (WinUI != null)
        {
            WinUI.SetActive(false);
        }
        isFinished = false;

        CheckAndSetLocks();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isFinished)
        {
            Continue("Stage2");
            Continue("Stage3");
            Continue("Stage4");
            Continue("Stage5");
        }

        if (FinalScore != null && FinalTime != null)
        {
        }

    }

    public void PindahScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
        Debug.Log("scene2");
    }

    

  

    public void Finish()
    {
       
            Time.timeScale = 0;
            if (WinUI != null)
            {
                WinUI.SetActive(true);
            }
            isFinished = true;
        
    }

    public void Continue(string key)
    {
        PlayerPrefs.SetInt(key, 1);
        SceneManager.LoadScene("StageSelection");

        CheckAndSetLocks();
    }

    public void back2()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Metode untuk memeriksa dan mengatur status gembok

    bool IsStage2Unlocked()
    {
        return PlayerPrefs.GetInt("Stage2", 0) == 1;
    }
    void CheckAndSetLocks()
    {
        if (locks != null)
        {
            for (int i = 0; i < locks.Length; i++)
            {
                string stageKey = "Stage" + (i + 2);

                if (PlayerPrefs.GetInt(stageKey, 0) == 1)
                {
                    if (locks[i] != null)
                    {
                        locks[i].SetActive(false);
                    }

                    if (IsStage2Unlocked())
                    {
                        DisableGembok();
                    }
                }
            }
        }
    }

    void DisableGembok()
    {
        if (gembok != null)
        {
            gembok.SetActive(false);
        }
    }

    void SetGembokActive(bool active)
    {
        if (gembok != null)
        {
            gembok.SetActive(active);
        }
    }


    

    
}
