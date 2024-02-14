using UnityEngine;

namespace Script.Inner.Object.Base
{
    public class Base : MonoBehaviour
    {
        public static int Hp = 100;

        private void OnCollisionEnter2D()
        {
            Hp--;
        }
    }
}
