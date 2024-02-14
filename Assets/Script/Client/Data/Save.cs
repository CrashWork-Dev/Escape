using UnityEngine;
using System.IO;
using Script.Inner.Object.Base;
using TMPro;

namespace Script.Client.Data
{
    public class Save : MonoBehaviour
    {
        private TMP_InputField _text;
        private struct PlayerDataStruct
        {
            public int Hp;
        }
        private PlayerDataStruct _playerData;
        
        public string json;
        public string filePath;

        private void Start()
        {
            _text = GameObject.FindGameObjectWithTag("Save").GetComponent<TMP_InputField>();
            if (!Directory.Exists(Application.persistentDataPath))
                Directory.CreateDirectory(Application.persistentDataPath);
            filePath = Application.persistentDataPath + "/" + "PlayerData.json";
        }

        public void Saving(bool save)
        {
            if (!save) return;
            _playerData.Hp = Base.Hp;
            json = JsonUtility.ToJson(_playerData);
            _text.text = json;
            File.WriteAllText(filePath,json);
        }

        public void Loading(bool load)
        {
            if (!load) return;
            if (File.Exists(filePath))
            {
                json = File.ReadAllText(filePath);
            }
            if (_text.text != null)
            {
                json = _text.text;
            }
            _playerData = JsonUtility.FromJson<PlayerDataStruct>(json);
            Base.Hp = _playerData.Hp;
        }
    }
}