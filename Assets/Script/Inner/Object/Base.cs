using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script.Inner.Object
{
    public class Base : MonoBehaviour
    {
        public static int Hp = 100;

        private void OnCollisionEnter2D(Collision2D other)
        {
            Hp--;
        }
    }
}
