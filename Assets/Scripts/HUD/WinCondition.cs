using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    [SerializeField]
    private Canvas WinScreen;
    [SerializeField]
    private Win WinScript;

    [SerializeField]
    private FlagVictory flagScript;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    { 
        WinScreen.enabled = false;
    }

    private void Update()
    {
        Condition();
    }
    

    private void Condition()
    {
        if (flagScript.PlayerWin == true)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        WinScript.UnlockNextLevel();
        WinScreen.enabled = true;
        Time.timeScale = 0.0f;
    }


}