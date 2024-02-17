using Script.Gaming.Client.UI.HUD.PausePanel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.Gaming.Client.UI.HUD.EndPanel
{
    public class Retry : MonoBehaviour
    {
        public void Restart()
        {
            PauseButton.IsPause = false;
            Time.timeScale = 1;
            SceneManager.LoadScene("Gaming");
        }
    }
}