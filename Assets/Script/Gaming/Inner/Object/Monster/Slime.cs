using System;
using UnityEngine;

namespace Script.Gaming.Inner.Object.Monster
{
    public class Slime : Monster
    {
        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void FixedUpdate()
        {
            AttackBase();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!other.gameObject.tag.Equals("Base")) return;
            Main.MonsterPool.Release(gameObject);
        }
    }
}