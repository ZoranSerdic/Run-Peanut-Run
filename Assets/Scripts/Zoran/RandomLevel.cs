using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel : MonoBehaviour
{
    int randomLevel;

    public GameObject Level_01;
    public GameObject Level_02;
    public GameObject Level_03;
    public GameObject Level_04;
    public GameObject Level_05;

    void Awake()
    {
        randomLevel = Random.Range(1, 5);

        Level_01.SetActive(false);
        Level_02.SetActive(false);
        Level_03.SetActive(false);
        Level_04.SetActive(false);
        Level_05.SetActive(false);
    }

    void Update()
    {
        switch (randomLevel)
        {
            default:
                Level_01.SetActive(true);
                break;

            case 1:
                Level_01.SetActive(true);
                break;
            case 2:
                Level_02.SetActive(true);
                break;
            case 3:
                Level_03.SetActive(true);
                break;
            case 4:
                Level_04.SetActive(true);
                break;
            case 5:
                Level_05.SetActive(true);
                break;
        }
    }
}
