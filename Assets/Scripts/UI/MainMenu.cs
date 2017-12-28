using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class MainMenu : MonoBehaviour {

    [SerializeField]
    private Button playButton;

    [SerializeField]
    private Button codeButton;

    [SerializeField]
    private Button creditsButton;

    [SerializeField]
    private Canvas codeScreen;

    [SerializeField]
    private Button quitButton;

    public Button PlayButton
    {
        get { return playButton; }
        set { playButton = value; }
    }

    public Button CodeButton
    {
        get { return codeButton; }
        set { codeButton = value; }
    }

    public Button CreditsButton
    {
        get { return creditsButton; }
        set { creditsButton = value; }
    }

    public Canvas CodeScreen
    {
        get { return codeScreen; }
        set { codeScreen = value; }
    }

    public Button QuitButton
    {
        get { return quitButton; }
        set { quitButton = value; }
    }


    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        codeScreen.enabled = false;
        VerifyToUnlockButtonStart();
    }

    private void Update()
    {
        UnlockButtonsIfCloseCodeScreen();
    }

    private void UnlockButtonsIfCloseCodeScreen()
    {
        if (!codeScreen.enabled)
        {
            EnableButtonsMainMenu();
            
            VerifyToUnlockButtonStart();
        }
    }

    private void EnableButtonsMainMenu()
    {
        quitButton.interactable = true;
        codeButton.interactable = true;
        creditsButton.interactable = true;
    }

    private void VerifyToUnlockButtonStart()
     {
        
        if (GameSave.instance.GameStats == Constants.Code.NUMBER_TO_UNLOCK_PLAY_BUTTON)
         {
          
             playButton.interactable = true;
         }
         else
         {
          
            playButton.interactable = false;
         }
     }

    public void CodePress()
    {
        codeScreen.enabled = true;
        DisableButtonsMainMenu();
    }

    private void DisableButtonsMainMenu()
    {
        quitButton.interactable = false;
        codeButton.interactable = false;
        playButton.interactable = false;
        creditsButton.interactable = false;
    }
}
