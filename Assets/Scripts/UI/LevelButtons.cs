using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour {

    [SerializeField]
    private Text loadingText;

    public Text LoadingText
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
        loadingText.enabled = false;
    }

    public void SelectedLvlPress(string numberLvl)
    {
        string nameScenelvl = Constants.SceneName.LVL + numberLvl;

        loadingText.enabled = true;
        SceneManager.LoadScene(nameScenelvl);
    }
}
