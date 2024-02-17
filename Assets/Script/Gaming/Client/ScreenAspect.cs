using UnityEngine;

namespace Script.Gaming.Client
{
    public class ScreenAspect : MonoBehaviour
    {
        public static float TargetAspect = 16f / 9f;
        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;

            var windowAspect = Screen.width / (float)Screen.height;

            var scaleHeight = windowAspect / TargetAspect;

            if (scaleHeight < 1)
            {
                var rect = _mainCamera.rect;

                rect.width = 1;
                rect.height = scaleHeight;
                rect.x = 0;
                rect.y = (1 - scaleHeight) / 2;

                _mainCamera.rect = rect;
            }
            else
            {
                var scaleWidth = 1 / scaleHeight;

                var rect = _mainCamera.rect;

                rect.width = scaleWidth;
                rect.height = 1;
                rect.x = (1 - scaleWidth) / 2;
                rect.y = 0;

                _mainCamera.rect = rect;
            }
        }
    }
}