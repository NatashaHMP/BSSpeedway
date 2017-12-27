using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour {

    [SerializeField]
    private int CurrentLevel;

    [SerializeField]
    private Button LvlButton;
    private void Start()
    {
        LoadResources();
        VerifyLevel();

    }

    private void LoadResources()
    {
        LvlButton.interactable = false;
    }

    private void VerifyLevel()
    {
        if (LevelControlers.instance.Levels[CurrentLevel] == Constants.LevelSave.NUMBER_UNLOCK_LEVEL)
        {
            LvlButton.interactable = true;
        }
    }
}
