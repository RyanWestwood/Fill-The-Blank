using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChanged : MonoBehaviour
{
    public Toggle m_Toggle;
    public string m_ToggleName;

    private void Start()
    {
        if (PlayerPrefs.GetInt(m_ToggleName) == 1)
        {
            m_Toggle.isOn = true;
        }
        else
        {
            m_Toggle.isOn = false;
        }
    }

    public void UpdateValue(bool value)
    {
        if(value == true)
        {
            PlayerPrefs.SetInt(m_ToggleName, 1);
        }
        else
        {
            PlayerPrefs.SetInt(m_ToggleName, 0);
        }
    }
}
