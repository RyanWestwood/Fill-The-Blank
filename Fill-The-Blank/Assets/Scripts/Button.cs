using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_BattlePass;
    public GameObject m_Avatar;
    public GameObject m_Currency;

    public GameObject m_MainMenuUI;
    public GameObject m_GameplayUI;

    public void AvatarClick()
    {
        Debug.Log("Avatar Opened!\n");
        m_Avatar.SetActive(true);
    }

    public void CurrencyClick()
    {
        Debug.Log("Currency Opened!\n");
        m_Currency.SetActive(true);
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
        m_Avatar.SetActive(false);
        m_Currency.SetActive(false);

        m_GameplayUI.SetActive(false);
        m_MainMenuUI.SetActive(true);
    }

    public void PlayClick()
    {
        Debug.Log("Play Game!\n");
        m_GameplayUI.SetActive(true);
        m_MainMenuUI.SetActive(false);
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