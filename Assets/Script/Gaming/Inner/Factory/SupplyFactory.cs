using UnityEngine;

namespace Script.Gaming.Inner.Factory
{
    public class SupplyFactory : AbstractFactory
    {
        public override GameObject Spawn(GameObject obj)
        {
            return Instantiate(obj);
        }
    }
}