using UnityEngine;

namespace Script.Client.Item.Monster
{
    public class Slime : Monster
    {
        private void Awake()
        {
            atk = 1;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Base.Hp--;
            Dead();
        }
    }
}