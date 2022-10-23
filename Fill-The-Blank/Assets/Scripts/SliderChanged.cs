using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderChanged : MonoBehaviour
{
    public TextMeshProUGUI m_Text;

    public void UpdateText(System.Single vol)
    {
        m_Text.text = vol.ToString();
    }
}