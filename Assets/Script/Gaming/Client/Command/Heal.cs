using Script.Gaming.Inner.Object.Base;
using UnityEngine;

namespace Script.Gaming.Client.Command
{
    public class Heal : MonoBehaviour
    {
        public void HealBase()
        {
            if (Base.Hp > 99)
            {
            }
            else
            {
                if (Base.BioMass <= 4) return;
                Base.BioMass -= 4;
                Base.Hp++;
            }
        }
    }
}