using Script.Gaming.Inner.Factory;
using Script.Gaming.Inner.Pool;
using UnityEngine;

namespace Script.Gaming
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