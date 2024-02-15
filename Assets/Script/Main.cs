using Script.Inner.Factory;
using Script.Inner.Pool;
using UnityEngine;

namespace Script
{
    public class Main : MonoBehaviour
    {
        public static MonsterPool MonsterPool;
        public static SupplyPool SupplyPool;
        public static AbstractFactory MonsterFactory;
        public static AbstractFactory SupplyFactory;

        private void Awake()
        {
            MonsterPool = gameObject.AddComponent<MonsterPool>();
            SupplyPool = gameObject.AddComponent<SupplyPool>();
            MonsterFactory = FactoryProducer.GetFactory("Monster");
            SupplyFactory = FactoryProducer.GetFactory("Supply");
        }
    }
}