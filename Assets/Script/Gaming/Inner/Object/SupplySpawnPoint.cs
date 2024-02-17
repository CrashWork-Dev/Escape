using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script.Gaming.Inner.Object
{
    public class SupplySpawnPoint : MonoBehaviour
    {
        [SerializeField] private GameObject[] supplyList;
        private float _randomPosition;

        private void RollPosition()
        {
            _randomPosition = Random.Range(-9.2f, 9.2f);
            var temp = transform.position;
            temp.x = _randomPosition;
            transform.position = temp;
        }

        private void Start()
        {
            Main.SupplyPool.Init(supplyList[0]);
            StartCoroutine(SupplySpawn());
        }

        private IEnumerator SupplySpawn()
        {
            yield return new WaitForSeconds(4);
            Main.SupplyPool.Spawn(gameObject);
            RollPosition();
            StartCoroutine(SupplySpawn());
        }
    }
}