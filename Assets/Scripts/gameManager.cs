using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] experiments;

    public void expActivate(int index)
    {
        for (int i = 0; i < experiments.Length; i++)
            experiments[i].SetActive(false);
        experiments[index].SetActive(true);
    }
}
