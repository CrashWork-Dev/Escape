using UnityEngine;

namespace Script.Client.Item.Monster
{
    public abstract class Monster : MonoBehaviour
    {
        public int atk;
        public void Dead()
        {
            Main.MonsterPool.Release(gameObject);
        }
    }
}