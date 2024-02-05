﻿using UnityEngine;

namespace Script.Inner.Object.Monster
{
    public class Slime : Monster
    {
        private void Start()
        {
            direction = (Vector3.zero - gameObject.transform.position).normalized;
        }

        private void FixedUpdate()
        {
            AttackBase();
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            Main.MonsterPool.Release(gameObject);
        }
    }
}