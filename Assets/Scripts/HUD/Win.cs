using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    [SerializeField]
    private int currentLevelNumber;
    private int nextLevel;

    public void UnlockNextLevel()
    {
       /* nextLevel = currentLevelNumber + 1;

        if (LevelControlers.instance.Levels[nextLevel] == Constants.LevelSave.NUMBER_LOCK_LEVEL &&
            currentLevelNumber < Constants.LevelSave.NUMBER_MAX_LEVELS)
        {
            LevelControlers.instance.Levels[nextLevel] = Constants.LevelSave.NUMBER_UNLOCK_LEVEL;
            SaveUnlockNextLevel();
        }*/
    }

    private void SaveUnlockNextLevel()
    {
        //PlayerPrefs.SetInt(LevelControlers.instance.LevelsKey + (nextLevel), LevelControlers.instance.Levels[nextLevel]);
    }
}
