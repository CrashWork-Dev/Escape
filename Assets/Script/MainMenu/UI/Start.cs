using Script.Gaming.Client.UI.HUD.PausePanel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.MainMenu.UI
{
    public class Start : MonoBehaviour
    {
        private void Awake()
        {
            PauseButton.IsPause = false;
            Time.timeScale = 1;
        }

        public void StartGame()
        {
            SceneManager.LoadSceneAsync("Gaming");
        }
    }
}