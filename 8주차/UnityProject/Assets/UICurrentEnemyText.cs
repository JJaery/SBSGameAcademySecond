﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICurrentEnemyText : MonoBehaviour
{
    public Text uiText;

    private void FixedUpdate()
    {
        uiText.text = $"남아있는 적 : {StageManager.Instance.currentEnemyList.Count}";
    }
}
