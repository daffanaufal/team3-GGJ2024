using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public Button buttonStage2;
    public Button buttonStage3;
    public GameObject quit;

    void Start()
    {

    }

    public void SelectStage(int stageIndex)
    {
        // Ganti "YourGameplayScene" dengan nama scene permainan yang sesuai
        SceneManager.LoadScene("CharacterSelection");
    }


    public void ResetStage()
    {
        PlayerPrefs.DeleteAll();
    }

    public void PreparingSave()
    {
        if (PlayerPrefs.HasKey("Stage2") == false)
        {
            PlayerPrefs.SetInt("Stage2", 1);
            PlayerPrefs.SetInt("StageBoss", 0);
        }
    }

    public void keluar()
    {
        quit.SetActive(true);
    }

    public void kembali()
    {
        SceneManager.LoadScene("CharacterSelection");
    }


}