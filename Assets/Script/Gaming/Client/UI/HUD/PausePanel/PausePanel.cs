using UnityEngine;

namespace Script.Gaming.Client.UI.HUD.PausePanel
{
    public class PausePanel : MonoBehaviour
    {
        public static GameObject Obj;

        private void Start()
        {
            Obj = gameObject;
            gameObject.SetActive(false);
        }
    }
}