using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject jeda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jedain()
    {
        jeda.SetActive(true);
        Time.timeScale = 0f;

    }

    public void tutup()
    {
        jeda.SetActive(false);
        Time.timeScale = 1f;

    }
}
