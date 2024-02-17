using UnityEngine;

namespace Script.Gaming.Inner.Object.Monster
{
    public abstract class Monster : MonoBehaviour
    {
        public Vector3 direction;
        public SpriteRenderer spriteRenderer;
        protected void AttackBase()
        {
            spriteRenderer.flipX = transform.position.x > 0;
            direction = - transform.position.normalized;
            transform.Translate(direction * (2f * Time.deltaTime));
        }
    }
}