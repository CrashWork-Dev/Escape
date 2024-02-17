using UnityEngine;

namespace Script.Gaming.Client.UI.HUD.EndPanel
{
    public class EndPanel : MonoBehaviour
    {
        public static GameObject Obj;

        private void Awake()
        {
            Obj = gameObject;
            gameObject.SetActive(false);
        }
    }
}