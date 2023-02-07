using UnityEngine;

namespace Cifp
{
    public class Settings
    {
        public bool IsPlaying = true;
        public bool IsPoster = true;

        public void Save()
        {
            string _json = JsonUtility.ToJson(CoreApp.Instance.Settings);
            PlayerPrefs.SetString("Prefs", _json);

            Debug.Log("Player preferences saved: " + _json);
        }
    }
}