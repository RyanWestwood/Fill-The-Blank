using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    public RectTransform m_Screen;
    public RectTransform m_Shop;
    public RectTransform m_Character;
    void Start()
    {
        Debug.Log("Helo\n");
        float w = m_Screen.rect.width;
        m_Shop.anchoredPosition = new Vector2(w, 0);
        m_Character.anchoredPosition = new Vector2(-w, 0);
    }
}
