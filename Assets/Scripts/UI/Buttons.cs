using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    [SerializeField]
    private Animator animatorSelectPlayer;

    [SerializeField]
    private Animator animatorCredits;



    private void Start()
    {
        Time.timeScale = 1.0f;
    }


    //MENU
    public void PlayPress()
    {
        animatorSelectPlayer.SetBool("ActiveSelectPlayer", true);
    }
    public void CreditPress()
    {
        animatorCredits.SetBool("ActiveCredits", true);
    }
    public void QuitPress()
    {
        Application.Quit();
    }

    //CREDITS
    public void BackCreditsPress()
    {
        animatorCredits.SetBool("ActiveCredits", false);
    }

    //SELECT PLAYER
    public void BackSelectPlayerPress()
    {
        animatorSelectPlayer.SetBool("ActiveSelectPlayer", false);
    }
    public void SelectPlayerPress()
    {
       
        SceneManager.LoadScene(Constants.SceneName.SELECT_LVL);

    }

    //SELECT LVL
    public void BackSelectLvlPress()
    {
   
        SceneManager.LoadScene(Constants.SceneName.MAIN_MENU);
    }


    //GAME WIN
    public void ContinuePress()
    {
    
        SceneManager.LoadScene(Constants.SceneName.SELECT_LVL);
    }
    public void RestartPress()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }



}
