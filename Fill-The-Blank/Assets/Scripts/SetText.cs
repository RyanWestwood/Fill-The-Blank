using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    private Localization m_LanguageTable;

    // Main Menu
    public TextMeshProUGUI m_BattlePass;
    public TextMeshProUGUI m_Play;
    public TextMeshProUGUI m_Zen;

    // Settings Menu
    public TextMeshProUGUI m_SettingsTitle;
    public TextMeshProUGUI m_Music;
    public TextMeshProUGUI m_TrackingTitle;
    public TextMeshProUGUI m_TrackingOption1;
    public TextMeshProUGUI m_TrackingOption2;

    // Avatar Menu
    public TextMeshProUGUI m_AvatarTitle;
    public TextMeshProUGUI m_AchievementsTitle;
    public TextMeshProUGUI m_Achievement1;
    public TextMeshProUGUI m_Achievement2;
    public TextMeshProUGUI m_Achievement3;
    public TextMeshProUGUI m_LeaderboardsTitle;

    // Currency Menu
    public TextMeshProUGUI m_CurrencyTitle;
    public TextMeshProUGUI m_WatchAd;

    // Upgrade Menu
    public TextMeshProUGUI m_UpgradeTitle;
    public TextMeshProUGUI m_BrushSize;
    public TextMeshProUGUI m_BallSize;
    public TextMeshProUGUI m_BallSpeed;
    public TextMeshProUGUI m_SizePowerUp;
    public TextMeshProUGUI m_AutoCompletion;
    public TextMeshProUGUI m_Buy1;
    public TextMeshProUGUI m_Buy2;
    public TextMeshProUGUI m_Buy3;
    public TextMeshProUGUI m_Buy4;
    public TextMeshProUGUI m_Buy5;

    // Cosmetic Menu
    public TextMeshProUGUI m_CosmeticTitle;
    public TextMeshProUGUI m_BrushTitle;
    public TextMeshProUGUI m_BallTitle;

    void Start()
    {
        m_LanguageTable = GetComponent<Localization>();

        // Main Menu
        m_BattlePass.text = m_LanguageTable.GetText("battle_pass");
        m_Play.text = m_LanguageTable.GetText("play");
        m_Zen.text = m_LanguageTable.GetText("zen");

        // Settings Menu
        m_SettingsTitle.text = m_LanguageTable.GetText("settings_title");
        m_Music.text = m_LanguageTable.GetText("music_title");
        m_TrackingTitle.text = m_LanguageTable.GetText("tracking_title");
        m_TrackingOption1.text = m_LanguageTable.GetText("tracking_option_1");
        m_TrackingOption2.text = m_LanguageTable.GetText("tracking_option_1");

        // Avatar Menu
        m_AvatarTitle.text = m_LanguageTable.GetText("profile_title");
        m_AchievementsTitle.text = m_LanguageTable.GetText("achievement_title");
        m_Achievement1.text = m_LanguageTable.GetText("achievement_one");
        m_Achievement2.text = m_LanguageTable.GetText("achievement_two");
        m_Achievement3.text = m_LanguageTable.GetText("achievement_three");
        m_LeaderboardsTitle.text = m_LanguageTable.GetText("leaderboard_title");

        // Currency Menu
        m_CurrencyTitle.text = m_LanguageTable.GetText("currency_title");
        m_WatchAd.text = m_LanguageTable.GetText("watch_ad");

        // Upgrade Menu
        m_UpgradeTitle.text = m_LanguageTable.GetText("upgrades");
        m_BrushSize.text = m_LanguageTable.GetText("brush_size");
        m_BallSize.text = m_LanguageTable.GetText("ball_size");
        m_BallSpeed.text = m_LanguageTable.GetText("ball_speed");
        m_SizePowerUp.text = m_LanguageTable.GetText("size_powerup");
        m_AutoCompletion.text = m_LanguageTable.GetText("autocompletion_powerup");
        m_Buy1.text = m_LanguageTable.GetText("buy");
        m_Buy2.text = m_LanguageTable.GetText("buy");
        m_Buy3.text = m_LanguageTable.GetText("buy");
        m_Buy4.text = m_LanguageTable.GetText("buy");
        m_Buy5.text = m_LanguageTable.GetText("buy");

        // Cosmetic Menu
        m_CosmeticTitle.text = m_LanguageTable.GetText("cosmetic_title");
        m_BrushTitle.text = m_LanguageTable.GetText("brush");
        m_BallTitle.text = m_LanguageTable.GetText("ball");
    } 
}