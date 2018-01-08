using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour {

    [SerializeField]
    private GameObject loadingText;

    public GameObject LoadingText
    {
        get { return loadingText; }
        set { loadingText = value; }
    }

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        loadingText.SetActive(false);
    }

    public void SelectedLvlPress(string numberLvl)
    {
        string nameScenelvl = Constants.SceneName.LVL + numberLvl;

        loadingText.SetActive(true);
        SceneManager.LoadScene(nameScenelvl);
    }
}
