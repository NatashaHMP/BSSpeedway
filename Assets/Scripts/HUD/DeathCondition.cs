using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCondition : MonoBehaviour
{

    [SerializeField]
    private Canvas deathScreen;

    private GameObject objPlayer;

    private string objectTag;

    private DeathPlayer deathPlayerScript;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        //objectTag = Constants.TagName.PLAYER;
        objectTag = "Player";
        deathScreen.enabled = false;
        objPlayer = GameObject.FindWithTag(objectTag);
        deathPlayerScript = objPlayer.GetComponent<DeathPlayer>();

    }

    private void Update()
    {
        Condition();
    }


    private void Condition()
    {
        if (deathPlayerScript.PlayerDied == true)
        {
            deathScreen.enabled = true;
            Time.timeScale = 0.0f;
        }
    }
}