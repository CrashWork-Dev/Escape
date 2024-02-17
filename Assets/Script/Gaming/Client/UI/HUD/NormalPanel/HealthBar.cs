using Script.Gaming.Inner.Object.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Gaming.Client.UI.HUD.NormalPanel
{
    public class HealthBar : MonoBehaviour
    {
        private Slider _healthBar;

        private void Start()
        {
            _healthBar = GetComponent<Slider>();
        }

        private void FixedUpdate()
        {
            _healthBar.value = Base.Hp;
        }
    }
}