using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_BattlePass;

    public void AvatarClick()
    {
        Debug.Log("Avatar Opened!\n");
    }

    public void CurrencyClick()
    {
        Debug.Log("Currency Opened!\n");
    }

    public void BattlePassClick()
    {
        Debug.Log("Battle Pass Opened!\n");
        m_MainMenu.SetActive(false);
        m_BattlePass.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        m_MainMenu.SetActive(true);
        m_BattlePass.SetActive(false);
    }

    public void PlayClick()
    {
        Debug.Log("Play Game!\n");
    }

    public void ZenClick()
    {
        Debug.Log("Zen Game!\n");
    }

    public void ShopClick()
    {
        Debug.Log("Shop Opened!\n");
    }

    public void GameClick()
    {
        Debug.Log("Game Opened!\n");
    }

    public void CharacterClick()
    {
        Debug.Log("Character Opened!\n");
    }
}