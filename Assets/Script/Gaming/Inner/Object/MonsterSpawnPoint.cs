using System.Collections;
using UnityEngine;

namespace Script.Gaming.Inner.Object
{
    public class MonsterSpawnPoint : MonoBehaviour
    {
        [SerializeField] private GameObject[] monsterList;
        private float _randomPosition;

        private void RollPosition()
        {
            _randomPosition = Random.Range(-4f, 5.4f);
            var temp = transform.position;
            temp.y = _randomPosition;
            transform.position = temp;
        }

        private void Start()
        {
            Main.MonsterPool.Init(monsterList[0]);
            StartCoroutine(EnemySpawn());
        }

        private IEnumerator EnemySpawn()
        {
            yield return new WaitForSeconds(2);
            Main.MonsterPool.Spawn(gameObject);
            RollPosition();
            StartCoroutine(EnemySpawn());
        }
    }
}