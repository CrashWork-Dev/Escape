using Script.Gaming.Inner.Object.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Gaming.Client.UI.HUD.NormalPanel
{
    public class BioMassBar : MonoBehaviour
    {
        private Slider _bioMassBar;

        private void Start()
        {
            _bioMassBar = GetComponent<Slider>();
        }

        private void FixedUpdate()
        {
            _bioMassBar.value = Base.BioMass;
        }
    }
}