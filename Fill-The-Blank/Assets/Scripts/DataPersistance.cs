using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataPersistance : MonoBehaviour
{
    public TextMeshProUGUI m_BrushesText;
    public TextMeshProUGUI m_UsernameText;

    private void Start()
    {
        SetString("Username", "Ryan W");
        m_BrushesText.text = GetInt("Brushes").ToString();
        m_UsernameText.text = GetString("Username");
    }
    public void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public int GetInt(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }

    public void SetString(string KeyName, string Value)
    {
        PlayerPrefs.SetString(KeyName, Value);
    }

    public string GetString(string KeyName)
    {
        return PlayerPrefs.GetString(KeyName);
    }
}
