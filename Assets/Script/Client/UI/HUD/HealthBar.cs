using Script.Inner.Object.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Client.UI.HUD
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