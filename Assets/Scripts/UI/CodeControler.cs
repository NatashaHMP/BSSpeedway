using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeControler : MonoBehaviour {

    [SerializeField]
    private Canvas codeScreen;

    [SerializeField]
    private Text messageInput;

    public Text MessageInput
    {
        get { return messageInput; }
        set { messageInput = value; }
    }

    public Canvas CodeScreen
    {
        get { return codeScreen; }
        set { codeScreen = value; }
    }

    private InputField codeInputField;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        codeInputField = GetComponent<InputField>();
    }

    public void BackPress()
    {
        codeScreen.enabled = false;

        CleanInputAndMessage();
    }

    public void SubmitPress()
    {
        if (codeInputField.text == Constants.Code.TEXT_RESET)
        {
            ResetCode();
        }
        else if (codeInputField.text == Constants.Code.TEXT_CODE)
        {
            EnterCorrectCode();
        }
        else
        {
            EnterIncorrectCode();
        }
    }

    private void ResetCode()
    {
        LockPlayButton();
        PlayerPrefs.DeleteAll();
        SetResetMessage();
    }

    private void EnterCorrectCode()
    {
        UnlockPlayButton();
        CleanInputAndMessage();

        codeScreen.enabled = false;
    }

    private void EnterIncorrectCode()
    {
        messageInput.text = Constants.Code.TEXT_CODE_INCORRECT;
    }

    private void LockPlayButton()
    {
        GameSave.instance.GameStats = Constants.Code.NUMBER_TO_LOCK_PLAY_BUTTON;
        GameSave.instance.SetNumberKeyGameStats();
    }

    private void UnlockPlayButton()
    {
        
        GameSave.instance.GameStats = Constants.Code.NUMBER_TO_UNLOCK_PLAY_BUTTON;
        
    }

    private void SetResetMessage()
    {
        messageInput.text = Constants.Code.TEXT_MESSAGE_RESET + GameSave.instance.GameStats;
    }

    private void CleanInputAndMessage()
    {
        codeInputField.text = "";
        messageInput.text = "";
    }
}
