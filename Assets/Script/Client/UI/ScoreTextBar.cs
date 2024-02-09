using Script.Inner.Object;
using Script.Inner.Object.Base;
using TMPro;
using UnityEngine;

namespace Script.Client.UI
{
    public class ScoreTextBar : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshProUGUI;
        private void Start()
        {
            _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        }

        private void FixedUpdate()
        {
            _textMeshProUGUI.text = "BaseHP: " + Base.Hp;
        }
    }
}