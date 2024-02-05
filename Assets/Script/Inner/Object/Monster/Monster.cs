using UnityEngine;

namespace Script.Inner.Object.Monster
{
    public abstract class Monster : MonoBehaviour
    {
        public Vector3 direction;

        protected void AttackBase()
        {
            transform.Translate(direction * (2f * Time.deltaTime));
        }
    }
}