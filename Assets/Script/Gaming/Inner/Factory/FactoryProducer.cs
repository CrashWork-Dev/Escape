using UnityEngine;

namespace Script.Gaming.Inner.Factory
{
    public static class FactoryProducer
    {
        public static AbstractFactory GetFactory(string which)
        {
            return which switch
            {
                "Supply" => ScriptableObject.CreateInstance<SupplyFactory>(),
                _ => ScriptableObject.CreateInstance<MonsterFactory>()
            };
        }
    }
}