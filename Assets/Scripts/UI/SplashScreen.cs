using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public sealed class SplashScreen : MonoBehaviour {

    [SerializeField]
    private float secondsToChange = 0f;

    private void Start()
    {
        StartCoroutine("Countdown");
    }

   
    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(secondsToChange);
        SceneManager.LoadScene(Constants.SceneName.MAIN_MENU);
    }
}
