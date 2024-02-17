using UnityEngine;

namespace Script.Gaming.Client.UI.HUD.NormalPanel
{
    public class NormalPanel : MonoBehaviour
    {
        public static GameObject Obj;

        private void Awake()
        {
            Obj = gameObject;
        }
    }
}