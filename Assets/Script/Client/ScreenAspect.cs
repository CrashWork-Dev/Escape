using UnityEngine;

namespace Script.Client
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

            if (scaleHeight < 1.0f)
            {
                var rect = _mainCamera.rect;

                rect.width = 1.0f;
                rect.height = scaleHeight;
                rect.x = 0;
                rect.y = (1.0f - scaleHeight) / 2.0f;

                _mainCamera.rect = rect;
            }
            else
            {
                var scaleWidth = 1.0f / scaleHeight;

                var rect = _mainCamera.rect;

                rect.width = scaleWidth;
                rect.height = 1.0f;
                rect.x = (1.0f - scaleWidth) / 2.0f;
                rect.y = 0;

                _mainCamera.rect = rect;
            }
        }
    }
}