using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    public RectTransform m_Screen;
    public RectTransform m_Shop;
    public RectTransform m_Character;
    public RectTransform m_Menu;
    public RectTransform m_BattlePass;
    
    void Start()
    {
        float w = m_Screen.rect.width;
        m_Shop.anchoredPosition = new Vector2(w, 0);
        m_Character.anchoredPosition = new Vector2(-w, 0);
    }

    public void ClampMainMenu()
    {
        float pos = Mathf.Clamp(m_Menu.anchoredPosition.x, -m_Screen.rect.width, m_Screen.rect.width);
        m_Menu.anchoredPosition = new Vector2(pos, 0);
    }

    public void ClampBattlePass()
    {
        //Debug.Log("Hello");
        //float pos = Mathf.Clamp(m_BattlePass.anchoredPosition.y, -1000, 1000);
        //m_BattlePass.anchoredPosition = new Vector2(0, pos);
    }
}
