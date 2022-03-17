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

    public event Action onLightsTrigger, onWindowTrigger;
    public void lightSwitchFlipped()
    {
        if (onLightsTrigger != null)
            onLightsTrigger();
    }

    public void windowTriggerEvent()
    {
        if (onWindowTrigger != null)
            onWindowTrigger();
    }
}
