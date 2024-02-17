using UnityEngine;

namespace Script.Gaming.Inner.Factory
{
    public abstract class AbstractFactory : ScriptableObject
    {
        public abstract GameObject Spawn(GameObject obj);
    }
}