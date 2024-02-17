using Script.Gaming.Client.Data;
using Script.Gaming.Client.UI.HUD.EndPanel;
using Script.Gaming.Client.UI.HUD.NormalPanel;
using Script.Gaming.Client.UI.HUD.PausePanel;
using UnityEngine;

namespace Script.Gaming.Inner.Object.Base
{
    public class Base : MonoBehaviour
    {
        public static int Hp = 100;
        public static int BioMass;

        private void FixedUpdate()
        {
            if (Hp > 100)
            {
                Hp = 100;
            }
        }

        private void OnCollisionEnter2D()
        {
            Hp--;
            //高效，但不符合直觉
            if (Hp < 1)
            {
                EndPanel.Obj.SetActive(true);
                NormalPanel.Obj.SetActive(false);
                PauseButton.Obj.SetActive(false);
                BioMass = 0;
                Hp = 100;
                Save.Saving();
            }

            BioMass++;
        }
    }
}