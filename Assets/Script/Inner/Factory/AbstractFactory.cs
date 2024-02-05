using UnityEngine;

namespace Script.Inner.Factory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
        public abstract GameObject Spawn(GameObject obj);
    }
}