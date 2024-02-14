using UnityEngine;

namespace Script.Inner.Factory
{
    public abstract class AbstractFactory : ScriptableObject
    {
        public abstract GameObject Spawn(GameObject obj);
    }
}