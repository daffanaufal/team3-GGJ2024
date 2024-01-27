using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmation : MonoBehaviour
{

    public GameObject confirm;
    public GameObject pengaturan;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confir()
    {
        confirm.SetActive(true);
    }

    public void tidak()
    { confirm.SetActive(false);
    }

    public void pengatur()
    {
        pengaturan.SetActive(true);
    }

    public void tutup()
    {
        pengaturan.SetActive(false );
    }

    public void keluar()
    {
        Application.Quit();
    }
}
