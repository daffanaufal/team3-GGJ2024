using System;
using DG.Tweening;
using UnityEngine;

namespace Controller
{
    public class StageController : MonoBehaviour
    {
        [SerializeField] private Vector2 nextLocation;
        private bool isBusy;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (isBusy) return;
            
            if (other.CompareTag("Player"))
            {
                isBusy = true;
                Camera.main.transform.DOMoveX(nextLocation.x, 1f).SetEase(Ease.InOutCubic).OnComplete(delegate
                {
                    isBusy = false;
                    
                });
            }
        }

    }
}
