using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameSave : MonoBehaviour 
{
    private int gameStats;

    public int GameStats
    {
        get { return gameStats; }
        set { gameStats = value; }
    }

    public static GameSave instance;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (instance != null)
        {
            Debug.LogError("Multiple instances of GameSave!");
        }

        instance = this;
    }

    private void Start () 
    {
        LoadResources();
	}

    private void LoadResources()
    {
       
        CheckIfPlayerHasKeyGameStats();
    }

    private void CheckIfPlayerHasKeyGameStats()
    {
        if(PlayerPrefs.HasKey(Constants.Code.TEXT_GAME_STATS))
        {
            
            GetNumberKeyGameStats();
        }
        else
        {
           
            SetNumberKeyGameStats();
        }
    }

    private void Update()
    {
        Unlock();
    }

    private void Unlock()
    {
       
        if (gameStats == Constants.Code.NUMBER_TO_UNLOCK_PLAY_BUTTON)
        {
            SetNumberKeyGameStats();
        }
    }

    private void GetNumberKeyGameStats()
    {
        gameStats = PlayerPrefs.GetInt(Constants.Code.TEXT_GAME_STATS);
    }

    public void SetNumberKeyGameStats()
    {
       
        PlayerPrefs.SetInt(Constants.Code.TEXT_GAME_STATS, gameStats);
    }
}
