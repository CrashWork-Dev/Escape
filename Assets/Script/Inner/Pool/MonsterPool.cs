using UnityEngine;
using UnityEngine.Pool;

namespace Script.Inner.Pool
{
    public class MonsterPool : MonoBehaviour
    {
        private ObjectPool<GameObject> _pool;
        private GameObject _monster;

        public void Init(GameObject monster)
        {
            _monster = monster;
            _pool = new ObjectPool<GameObject>(CreateFunc, ActionOnGet, ActionOnRelease, ActionOnDestroy, true, 1, 4);
        }

        private GameObject CreateFunc()
        {
            return Main.MonsterFactory.Spawn(_monster);
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
            _pool.Release(obj);
        }

        public GameObject Spawn(GameObject parent)
        {
            var temp = _pool.Get();
            temp.transform.position = parent.transform.position;
            return temp;
        }
    }
}