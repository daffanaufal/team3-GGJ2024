using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmation : MonoBehaviour
{

    public GameObject confirm;
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

    public void keluar()
    {
        Application.Quit();
    }
}
