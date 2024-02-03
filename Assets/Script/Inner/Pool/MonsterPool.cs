using UnityEngine;
using UnityEngine.Pool;

namespace Script.Inner.Pool
{
    public class MonsterPool : MonoBehaviour
    {
        public static ObjectPool<GameObject> Pool;
        private GameObject _monster;

        public void Init(GameObject monster)
        {
            _monster = monster;
            Pool = new ObjectPool<GameObject>(CreateFunc, ActionOnGet, ActionOnRelease, ActionOnDestroy, true, 1, 4);
        }

        private void ActionOnDestroy(GameObject obj)
        {
            Destroy(obj);
        }

        private void ActionOnRelease(GameObject obj)
        {
            obj.SetActive(false);
        }

        private void ActionOnGet(GameObject obj)
        {
            obj.SetActive(true);
        }

        public void Release(GameObject obj)
        {
            Pool.Release(obj);
        }

        public GameObject Spawn()
        {
            return Pool.Get();
        }
        
        private GameObject CreateFunc()
        {
            return Main.Factory.Spawn(_monster);
        }
    }
}