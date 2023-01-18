using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    public DataHolder m_Table;

    void Start()
    {
        m_Table = GetComponent<DataHolder>();
    }

    public void Test()
    {
        m_Table.GetBrush("one");
    }
}
