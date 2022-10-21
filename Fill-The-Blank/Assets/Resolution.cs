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
    void Start()
    {
        float w = m_Screen.rect.width;
        m_Shop.anchoredPosition = new Vector2(w, 0);
        m_Character.anchoredPosition = new Vector2(-w, 0);
    }

    public void Clamp()
    {
        float pos = Mathf.Clamp(m_Menu.anchoredPosition.x, -m_Screen.rect.width, m_Screen.rect.width);
        m_Menu.anchoredPosition = new Vector2(pos, 0);
    }
}
