using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCount : MonoBehaviour
{

    public int NumberStars
    {
        get { return numberStars; }
        set { numberStars = value; }
    }
    private int numberStars;


    [SerializeField]
    private Canvas WinScreen;

    [SerializeField]
    private GameObject[] stars = new GameObject[3];

    private int numberOfStar = 3;

    private void Start()
    {
        numberStars = 0;

        for (int i = 0; i < numberOfStar; i++)
        {
            stars[i].SetActive(false);
        }
    }


    private void Update()
    {
        if (WinScreen.isActiveAndEnabled)
        {
            for (int i = 0; i < numberStars; i++)
            {
                stars[i].SetActive(true);

            }
        }
    }


}
