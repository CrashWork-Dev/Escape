using UnityEngine;

namespace Script.Inner.Factory
{
    public class SupplyFactory : AbstractFactory
    {
        public override GameObject Spawn(GameObject obj)
        {
            return Instantiate(obj);
        }
    }
}