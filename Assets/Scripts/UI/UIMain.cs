using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : UIBase
{
    public Image hpBar;
    public Image mpBar;
    public Image expBar;

    public TextMeshProUGUI levelText;
    public TextMeshProUGUI goldText;

    public TextMeshProUGUI stageText;
    public TextMeshProUGUI waveText;
    public Image waveBar;

    private void Update()
    {
        UpdatePlayerStatUI();
    }

    private void UpdatePlayerStatUI()
    {
        hpBar.fillAmount = GameManager.Instance.Player.StatInfo.currentHp / GameManager.Instance.Player.StatInfo.maxHp;
        mpBar.fillAmount = GameManager.Instance.Player.StatInfo.currentMp / GameManager.Instance.Player.StatInfo.maxMp;
        expBar.fillAmount = GameManager.Instance.Player.StatInfo.currentExp / GameManager.Instance.Player.StatInfo.maxExp;

        levelText.text = GameManager.Instance.Player.StatInfo.currentLevel.ToString();
        goldText.text = GameManager.Instance.Player.StatInfo.currentGold.ToString();

        stageText.text = StageManager.Instance.currentStageLevel.ToString() + " 스테이지";
        waveText.text = "남아있는 몬스터 수: " + StageManager.Instance.currentEnemyList.Count;
        waveBar.fillAmount = StageManager.Instance.GetPercentage();
    }
}
