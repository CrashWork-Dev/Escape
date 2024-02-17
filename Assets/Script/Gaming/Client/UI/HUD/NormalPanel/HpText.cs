using Script.Gaming.Inner.Object.Base;
using TMPro;
using UnityEngine;

namespace Script.Gaming.Client.UI.HUD.NormalPanel
{
    public class HpText : MonoBehaviour
    {
        private TMP_Text _text;

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void FixedUpdate()
        {
            _text.text = "HP:" + Base.Hp + "/100";
        }
    }
}