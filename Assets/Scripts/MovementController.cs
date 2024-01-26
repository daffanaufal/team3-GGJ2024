using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private LegController lengLeft;
    [SerializeField] private LegController lengRight;
    [SerializeField] private float moveDistance;

    private bool _isBusy;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Move ");
            // Move leg Right
            Move(lengRight);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Move ");
            // Move leg Left
            Move(lengLeft);
        }
    }

    private void Move(LegController leg)
    {
        _isBusy = true;
        switch (leg.GetLegPosition())
        {
            case LegController.LegPosition.Back:
                Debug.Log("Move Forward");
                leg.transform.Translate(moveDistance, 0f, 0f);
                break;
            case LegController.LegPosition.Front:
                Debug.Log("Move Backward");
                leg.transform.Translate(-moveDistance, 0f, 0f);
                break;
        }
        SwitchLegs();
        _isBusy = false;
    }

    private void SwitchLegs()
    {
        lengLeft.SwitchLegPosition();
        lengRight.SwitchLegPosition();
    }
}