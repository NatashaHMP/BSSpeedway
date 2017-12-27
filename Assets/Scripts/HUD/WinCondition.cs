using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    [SerializeField]
    private Canvas WinScreen;
    private GameObject objPlayer;
    [SerializeField]
    private Win WinScript;
    private string objectTag;

 

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        Debug.Log(Time.timeScale);
        //objectTag = Constants.TagName.PLAYER;
        objectTag = "Player";
        WinScreen.enabled = false;
        objPlayer = GameObject.FindWithTag(objectTag);   
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == objectTag)
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