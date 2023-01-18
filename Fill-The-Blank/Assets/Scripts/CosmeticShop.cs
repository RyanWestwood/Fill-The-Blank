using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ButtonInfo
{
    string name;
    Sprite image;
}

[Serializable]
public class Icons
{
    public DataTable<Sprite> m_Brushes = new DataTable<Sprite>();
    public GameObject[] m_Buttons;

    public void Initialize()
    {
        m_Brushes.Initialize();

        int index = 0;
        foreach (var item in m_Brushes.GetDict())
        {
            m_Buttons[index].GetComponentInChildren<Image>().sprite = item.Value;
            index++;
        }
        Debug.Log("hi");
    }
}

public class CosmeticShop : MonoBehaviour
{
    public Icons m_Brushes;
    public Icons m_Balls;

    private void Start()
    {
        m_Brushes.Initialize();
        m_Balls.Initialize();
    }

    private void Update()
    {
        //Debug.Log("£");
    }
}
