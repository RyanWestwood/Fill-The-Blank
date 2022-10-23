using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_BattlePass;
    public GameObject m_Avatar;
    public GameObject m_Currency;
    public GameObject m_Settings;

    public GameObject m_MainMenuUI;
    public GameObject m_GameplayUI;

    public GameObject m_GameOver;

    public TextMeshProUGUI m_BrushesText;

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
        DestroyAllBrushes();
        m_MainMenu.SetActive(true);
        m_BattlePass.SetActive(false);
        m_Avatar.SetActive(false);
        m_Currency.SetActive(false);
        m_Settings.SetActive(false);
        m_GameOver.SetActive(false);

        m_GameplayUI.SetActive(false);
        m_MainMenuUI.SetActive(true);
    }

    public void PlayClick()
    {
        DestroyAllBrushes();
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

    public void SettingsClick()
    {
        Debug.Log("Character Opened!\n");
        m_Settings.SetActive(true);
    }

    public void IncreaseBushes()
    {
        var current = PlayerPrefs.GetInt("Brushes");
        current += 25;
        PlayerPrefs.SetInt("Brushes", current);
        m_BrushesText.text = current.ToString();
    }

    //  Temp until gameplay is optimised. 
    private void DestroyAllBrushes()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Brush");
        foreach (GameObject obj in taggedObjects)
        {
            Destroy(obj);
        }
    }

    public void DebugGameplayFinish()
    {
        m_GameOver.SetActive(true);
    }
}