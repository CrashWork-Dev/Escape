using Script.Inner.Object.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Client.UI.HUD
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