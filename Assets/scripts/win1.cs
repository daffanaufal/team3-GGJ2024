using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class win1 : MonoBehaviour
{
    public GameObject men1;
    public GameObject win2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menang1()
    {
        men1.SetActive(true);
        Time.timeScale = 0f;
    }
    public void menang2()
    {
        win2.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ulang()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void lanjutkeun()
    {
        SceneManager.LoadScene("StageSelection");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Dapatkan objek pemain
            GameObject player = other.gameObject;

            // Pindahkan pemain ke posisi yang ditentukan


            menang2();
        }
    }
}
