using UnityEngine;

namespace Script.Inner.Object.Base
{
    public class Base : MonoBehaviour
    {
        public static int Hp = 100;
        public static int BioMass;

        private void OnCollisionEnter2D()
        {
            Hp--;
            BioMass++;
        }
    }
}