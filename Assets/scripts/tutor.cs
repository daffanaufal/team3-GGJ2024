using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FUE;
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutupdulu()
    {
        FUE.SetActive(false);
        Time.timeScale = 1f;

    }
}
