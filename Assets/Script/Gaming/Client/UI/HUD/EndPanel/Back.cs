using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.Gaming.Client.UI.HUD.EndPanel
{
    public class Back : MonoBehaviour
    {
        public void BackToMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}