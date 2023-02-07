using Cifp;
using System.Collections.Generic;
using UnityEngine;

public class CoreApp
{
    private static CoreApp _instance;
    private Settings _settings;
    private List<Planeta> _planetas = null;

    public List<Planeta> Planetas
    {
        get
        {
            if (this._planetas == null)
            {
                IDataProvider dao = new JsonDataProvider();
                this._planetas = dao.GetPlanetas();
            }

            return _planetas;
        }
    }

    public Settings Settings
    {
        get
        {
            return this._settings;
        }
    }


    public static CoreApp Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CoreApp();
            }

            return _instance;
        }
    }

    public CoreApp() {

        // load player preferences
        string playerPrefs = PlayerPrefs.GetString("Prefs");
        if (!string.IsNullOrWhiteSpace(playerPrefs))
        {
            Debug.Log(playerPrefs);
            this._settings = JsonUtility.FromJson<Settings>(playerPrefs);
        }
        else
        {
            this._settings = new Settings();
        }
    }   
}