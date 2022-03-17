using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEvents : MonoBehaviour
{
    public static gameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onLightsTrigger;
    public void lightSwitchFlipped()
    {
        if (onLightsTrigger != null)
            onLightsTrigger();
    }
}
