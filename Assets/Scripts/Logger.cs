﻿using System.Linq;
using DilmerGames.Core.Singletons;
using TMPro;
using UnityEngine;

public class Logger : Singleton<Logger>
{   
    [SerializeField]
    private TextMeshProUGUI debugAreaText = null;

    [SerializeField]
    private bool enableDebug = false;

    [SerializeField]
    private int maxLines = 15;

    void OnEnable() 
    {
        debugAreaText.enabled = enableDebug;
        enabled = enableDebug;
    }

    public void LogInfo(string message)
    {
        ClearLines();
        debugAreaText.text += $"<color=\"green\">{message}</color>\n";
    }

    public void LogError(string message)
    {
        ClearLines();
        debugAreaText.text += $"<color=\"red\">{message}</color>\n";
    }

    public void LogWarning(string message)
    {
        ClearLines();
        debugAreaText.text += $"<color=\"yellow\">{message}</color>\n";
    }

    private void ClearLines()
    {
        if(debugAreaText.text.Split('\n').Count() >= maxLines)
        {
            debugAreaText.text = string.Empty;
        }
    }
}