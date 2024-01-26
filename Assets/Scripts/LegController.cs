using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegController : MonoBehaviour
{
    public enum LegPosition
    {
        Front,
        Back,
    }

    [SerializeField] private LegPosition legPosition;
    
    public void SwitchLegPosition()
    {
        switch (legPosition)
        {
            case LegPosition.Back:
                legPosition = LegPosition.Front;
                break;
            case LegPosition.Front:
                legPosition = LegPosition.Back;
                break;
        }
    }

    public LegPosition GetLegPosition()
    {
        return legPosition;
    }
}
