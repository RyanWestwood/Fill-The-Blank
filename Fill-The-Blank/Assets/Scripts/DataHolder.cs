using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class DataTable<T>
{
    [Serializable]
    public struct Item
    {
        public string name;
        public T value;
    }

    public Item[] Items;
    private Dictionary<string, T> m_Items = new Dictionary<string, T>();

    public void Initialize()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            m_Items.Add(Items[i].name, Items[i].value);
        }
    }

    public T GetItem(string name)
    {
        if (m_Items.ContainsKey(name))
        {
            Debug.Log("Key found: " + name);
            return m_Items[name];
        }
        Debug.Log("Key not found: " + name);
        return default(T);
    }
}

public class DataHolder : MonoBehaviour
{
    public DataTable<Texture2D> m_Brushes = new DataTable<Texture2D>();
    public DataTable<Texture2D> m_Balls = new DataTable<Texture2D>();
    public DataTable<string> m_Names = new DataTable<string>();

    private void Awake()
    {
        m_Brushes.Initialize();
        m_Balls.Initialize();
        m_Names.Initialize();
    }
}