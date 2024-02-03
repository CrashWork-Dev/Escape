using Script.Inner.Factory;
using Script.Inner.Pool;
using UnityEngine;
namespace Script
{
    public class Main : MonoBehaviour
    {
        public static MonsterPool MonsterPool;
        public static AbstractFactory Factory;
        private void Awake()
        {
            MonsterPool = gameObject.AddComponent<MonsterPool>();
            Factory = FactoryProducer.GetFactory("Monster");
        }
    }
}