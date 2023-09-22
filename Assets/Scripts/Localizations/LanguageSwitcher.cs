using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Dropdown))]
public class LanguageSwitcher : MonoBehaviour
{
    private void Awake()
    {
        TMP_Dropdown dropDown = GetComponent<TMP_Dropdown>();

        //fill in the values
        dropDown.options = new List<TMP_Dropdown.OptionData>();

        foreach (string  language in Data.LANGUAGES)
        {
            dropDown.options.Add(new TMP_Dropdown.OptionData(language));
        }
        // set callback to fire event
        dropDown.onValueChanged.AddListener((int i) =>
         {
             string language = Data.LANGUAGES[i];
             Data.CURRENT_LANGUAGE = language;
             Data.OnLanguageChanged.Invoke();
         }
        );
    }
}
