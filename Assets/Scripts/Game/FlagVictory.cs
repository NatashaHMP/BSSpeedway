using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagVictory : MonoBehaviour {

    public bool PlayerWin
    {
        get { return playerWin; }
        set { playerWin = value; }
    }
    private bool playerWin;

    private string objectTag;

    private void Start()
    {
        LoadResources();
    }


    private void LoadResources()
    {
        playerWin = false;
        objectTag = Constants.TagName.PLAYER;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            playerWin = true;
        }
    }
}
