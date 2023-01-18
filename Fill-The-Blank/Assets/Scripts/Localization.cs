using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum Language
{
    English = 0,
    Spanish,
    French,
    Italian
};

[Serializable]
public struct LanguageArray
{
    public string[] language;
}

public class Localization : MonoBehaviour
{
    public Language ChosenLanguage;
    public DataTable<LanguageArray> Languages = new DataTable<LanguageArray>();

    private void Awake()
    {
        Languages.Initialize();
    }

    public string GetText(string text_id)
    {
        return Languages.GetItem(text_id).language[(int)ChosenLanguage];
    }
}