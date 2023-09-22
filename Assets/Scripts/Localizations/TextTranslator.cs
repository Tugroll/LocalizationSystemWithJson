using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextTranslator : MonoBehaviour
{
    TextMeshProUGUI text;
    string key;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        key = text.text;
        SetText();
        Data.OnLanguageChanged.AddListener(SetText);
        
    }

    private void SetText()
    {
        text.text = Data.LOCALIZATION[key][Data.CURRENT_LANGUAGE];
    }
}

