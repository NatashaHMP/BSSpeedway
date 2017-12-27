using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField]
    private StarCount starCountScript;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == /*Constants.TagName.PLAYER*/ "Player")
        {
            AddStar();
            gameObject.SetActive(false);
        }
    }

    private void AddStar()
    {
        starCountScript.NumberStars++;
    }

}
