using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public struct Item<T>
{
    public string name;
    public T value;
}

[Serializable]
public class DataTable<T>
{
    public Item<T>[] Items;
    private Dictionary<string, T> m_Items = new Dictionary<string, T>();

    public void Initialize()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            m_Items.Add(Items[i].name, Items[i].value);
        }
    }

    public Dictionary<string, T> GetDict()
    {
        return m_Items;
    }

    public T GetItem(string name)
    {
        if (m_Items.ContainsKey(name))
        {
            return m_Items[name];
        }
        Debug.LogError("Key not found: " + name);
        return default(T);
    }
}