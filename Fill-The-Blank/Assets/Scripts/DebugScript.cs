using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugScript : MonoBehaviour
{
    public Localization m_Table;
    public TextMeshProUGUI m_BattlePass;

    void Start()
    {
        m_Table = GetComponent<Localization>();
        //m_BattlePass.text = 
    }

    public void Test()
    {
        m_BattlePass.text = m_Table.GetText("hello");
    }
}
