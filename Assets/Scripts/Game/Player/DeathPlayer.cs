using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{


    private string objectTag;
    public bool PlayerDied
    {
        get { return playerDied; }
        set { playerDied = value; }
    }
    private bool playerDied;
    [SerializeField]
    private GameObject explosion;
    private Rigidbody carRB;

    private void Start()
    {
        LoadResources();
    }


    private void LoadResources()
    {
        carRB = gameObject.GetComponent<Rigidbody>();
        playerDied = false;
        objectTag = Constants.TagName.FLOOR;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            playerDied = true;
            carRB.isKinematic = true;
        }
    }
}