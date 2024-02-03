using System.Collections.Generic;
using UnityEngine;

namespace Script.Client.Item
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private List<GameObject> monsterList;
        //生成测试
        private void Start()
        {
            Main.MonsterPool.Init(monsterList[0]);
            Main.MonsterPool.Spawn().gameObject.transform.position = transform.position;
        }
    }
}