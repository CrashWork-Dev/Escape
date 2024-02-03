using UnityEngine;

namespace Script.Inner.Factory
{
    public class MonsterAbstractFactory : AbstractFactory
    {
        public override GameObject Spawn(GameObject obj)
        {
            return Instantiate(obj);
        }
    }
}