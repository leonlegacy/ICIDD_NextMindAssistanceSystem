using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp1 : MonoBehaviour
{
    public int flipCount = 0;
    private void Start()
    {
        gameEvents.current.onLightsTrigger += lightFlipCount;
    }

    void lightFlipCount()
    {
        flipCount++;
    }

    private void OnDestroy()
    {
        gameEvents.current.onLightsTrigger -= lightFlipCount;
    }
}
