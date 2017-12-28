using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlers : MonoBehaviour {

    [SerializeField]
    private int[] levels = new int[Constants.LevelSave.NUMBER_MAX_LEVELS];

    [SerializeField]
    private static string levelsKey = Constants.LevelSave.TEXT_LEVELS_KEY;

    public int[] Levels
    {
        get { return levels; }
        set { levels = value; }
    }

    public string LevelsKey
    {
        get { return levelsKey; }
    }

    public static LevelControlers instance;

    private void Awake()
    {
        instance = this;
       
    }

    private void Start()
    {
       
        LoadResources();
    }

    private void LoadResources()
    {
        LockOrUnlockLevels();
    }

    private void LockOrUnlockLevels()
    {
        levels[Constants.LevelSave.INDEX_LEVEL_ONE] = Constants.LevelSave.NUMBER_UNLOCK_LEVEL;

        for (int i = Constants.LevelSave.INDEX_LEVEL_ONE; i < Constants.LevelSave.NUMBER_MAX_LEVELS; i++)
        {
            if (PlayerPrefs.HasKey(LevelsKey + i))
            {
                levels[i] = PlayerPrefs.GetInt(LevelsKey + i);
            }
            else
            {
                PlayerPrefs.SetInt(LevelsKey + i, levels[i]);
            }
        }
    }
}
