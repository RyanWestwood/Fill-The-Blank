using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    [Serializable]
    public struct Icon
    {
        public string name;
        public Texture2D image;
    }

    public Icon[] Brushes;
    private Dictionary<string, Texture2D> m_Brushes = new Dictionary<string, Texture2D>();

    public Icon[] Balls;
    private Dictionary<string, Texture2D> m_Balls = new Dictionary<string, Texture2D>();

    void Start()
    {
        CreateDictionary(Brushes, m_Brushes);
        CreateDictionary(Balls, m_Balls);
    }

    public Texture2D GetBrush(string name)
    {
        if (m_Brushes.ContainsKey(name))
        {
            Debug.Log("Brush key found: " + name);
            return m_Brushes[name];
        }
        Debug.Log("Brush key not found: " + name);
        return new Texture2D(64,64);
    }

    public Texture2D GetBall(string name)
    {
        if (m_Balls.ContainsKey(name))
        {
            Debug.Log("Brush key found: " + name);
            return m_Balls[name];
        }
        Debug.Log("Brush key not found: " + name);
        return new Texture2D(64, 64);
    }

    private void CreateDictionary(Icon[] array, Dictionary<string, Texture2D> dict)
    {
        for (int i = 0; i < array.Length; i++)
        {
            dict.Add(array[i].name, array[i].image);
        }
    }
}
