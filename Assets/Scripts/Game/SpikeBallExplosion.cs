using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallExplosion : MonoBehaviour {

    private string objectTag;
    [SerializeField]
    private GameObject explosion;
   

    private void Start()
    {
        LoadResources();
    }


    private void LoadResources()
    {
        objectTag = Constants.TagName.PLAYER;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }

}
