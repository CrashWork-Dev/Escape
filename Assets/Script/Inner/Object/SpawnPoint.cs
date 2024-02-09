using System.Collections;
using UnityEngine;

namespace Script.Inner.Object
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private GameObject[] monsterList;
        private void Start()
        {
            Main.MonsterPool.Init(monsterList[0]);
            StartCoroutine(EnemySpawn());
        }
        private IEnumerator EnemySpawn()
        {
            yield return new WaitForSeconds(2);
            Main.MonsterPool.Spawn(gameObject);
            StartCoroutine(EnemySpawn());
        }
    }
}