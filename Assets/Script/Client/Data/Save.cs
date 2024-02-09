using System;
using Script.Inner.Object;
using UnityEngine;
using System.IO;
using Script.Inner.Object.Base;

namespace Script.Client.Data
{
    public class Save : MonoBehaviour
    {
        private struct PlayerDataStruct
        {
            public int Hp;
        }
        private PlayerDataStruct _playerData;
        
        public string json;
        public string filePath;

        private void Start()
        {
            if (!Directory.Exists(Application.persistentDataPath))
                Directory.CreateDirectory(Application.persistentDataPath);
            filePath = Application.persistentDataPath + "/" + "Save.json";
        }

        public void Saving(bool save)
        {
            if (save)
            {
                _playerData.Hp = Base.Hp;
                json = JsonUtility.ToJson(_playerData,true);
                File.WriteAllText(filePath,json);
            }
        }

        public void Loading(bool load)
        {
            if (load)
            {
                json = File.ReadAllText(filePath);
                _playerData = JsonUtility.FromJson<PlayerDataStruct>(json);
                Base.Hp = _playerData.Hp;
            }
        }
    }
}