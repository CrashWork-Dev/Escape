using System.IO;
using Script.Gaming.Inner.Object.Base;
using TMPro;
using UnityEngine;

namespace Script.Gaming.Client.Data
{
    public class Save : MonoBehaviour
    {
        private static TMP_InputField _text;

        public struct PlayerDataStruct
        {
            public int Hp;
            public int BioMass;
        }

        public static PlayerDataStruct PlayerData;

        private static string _json;
        private static string _filePath;

        private void Awake()
        {
            _text = GameObject.FindGameObjectWithTag("Save").GetComponent<TMP_InputField>();
            if (!Directory.Exists(Application.persistentDataPath))
                Directory.CreateDirectory(Application.persistentDataPath);
            _filePath = Application.persistentDataPath + "/" + "PlayerData.json";
            Loading();
        }

        public static void Saving()
        {
            PlayerData.Hp = Base.Hp;
            PlayerData.BioMass = Base.BioMass;
            _json = JsonUtility.ToJson(PlayerData);
            _text.text = _json;
            File.WriteAllText(_filePath, _json);
        }

        public void Loading()
        {
            if (File.Exists(_filePath))
            {
                _json = File.ReadAllText(_filePath);
            }

            if (!_text.text.Equals(""))
            {
                _json = _text.text;
            }

            if (_json.Equals("")) return;
            print(_json);
            PlayerData = JsonUtility.FromJson<PlayerDataStruct>(_json);
            Base.Hp = PlayerData.Hp;
            Base.BioMass = PlayerData.BioMass;
        }
    }
}