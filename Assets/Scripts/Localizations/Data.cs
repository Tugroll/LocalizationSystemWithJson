using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Events;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public static class Data
{
   
    public static string CURRENT_LANGUAGE = "en";
    
    
    #region
    //public static Dictionary<string, Dictionary<string, string>> LOCALIZATION
    //    = new Dictionary<string, Dictionary<string, string>>()
    //{
    //    { "Play", new Dictionary<string, string>()
    //    {
    //        {"en","play" },
    //        {"tr","oyna" }
    //    }

    //    },

    //};
    #endregion
    private static string[] _LANGUAGES;
    public static string[] LANGUAGES {
        get
        {
            if (_LANGUAGES == null) _LoadLocalizationData();
            return _LANGUAGES;
        }
    }
    private static Dictionary<string, Dictionary<string, string>> _LOCALIZATION;
    public static Dictionary<string,Dictionary<string,string>> LOCALIZATION
    {
        get
        {
            if(_LOCALIZATION == null) _LoadLocalizationData();
            return _LOCALIZATION;
        }
    }

    private static UnityEvent _OnLanguageChanged;
    public static UnityEvent OnLanguageChanged { 
        get 
        {
            if (_OnLanguageChanged == null)
                _OnLanguageChanged = new UnityEvent();
            return _OnLanguageChanged;
        } 
    }
    public static string GetSceneName()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        return sceneName;
    }
    private static string _ReadFromFile(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            return "Warning";
        }
    }
    public static void _LoadLocalizationData()
    {
        
        _LOCALIZATION = new Dictionary<string, Dictionary<string, string>>();
        string json = _ReadFromFile(Path.Combine(Application.dataPath,"Scripts","Localizations","MainMenu.json") );
        Debug.Log(json);
        LocalizationData d = JsonConvert.DeserializeObject<LocalizationData>(json);
        _LANGUAGES = d.languages;
       
        foreach (LocalizationMapping map in d.table)
        {
            _LOCALIZATION[map.key] = new Dictionary<string, string>();
            foreach (LocalizationValue val in map.values)
            {
                _LOCALIZATION[map.key].Add(val.lang, val.value);
            }
        }
    }
}