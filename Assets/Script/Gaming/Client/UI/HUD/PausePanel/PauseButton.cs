using UnityEngine;

namespace Script.Gaming.Client.UI.HUD.PausePanel
{
    public class PauseButton : MonoBehaviour
    {
        public static bool IsPause;
        public static GameObject Obj;

        private void Start()
        {
            Obj = gameObject;
        }

        private void Update()
        {
            Pause();
        }

        private static void Pause()
        {
            Time.timeScale = IsPause ? 0 : 1;
        }

        public void Switch()
        {
            IsPause = !IsPause;
            PausePanel.Obj.SetActive(IsPause);
        }
    }
}