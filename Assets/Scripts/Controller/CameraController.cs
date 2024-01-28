using DG.Tweening;
using Test_Script;
using UnityEngine;

namespace Controller
{
    public class CameraController : MonoBehaviour
    {

        private Camera currentCameraPlayer;
        
        private void Start()
        {
            // PlayerManager.Instance.ONRestartPlayer += InstanceOnRestartPlayer;
            currentCameraPlayer = GetComponent<Camera>();

        }

        private void InstanceOnRestartPlayer()
        {
            // currentCameraPlayer.transform.DOMoveX(0, 1).SetEase(Ease.InOutCubic);
        }
    }
}
