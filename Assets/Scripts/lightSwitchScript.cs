using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitchScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] linkedLights;
    [SerializeField]
    AudioSource switchSFX;

    public bool lightState = true;


    public void setLights(bool state)
    {
        for (int i = 0; i < linkedLights.Length; i++)
            linkedLights[i].SetActive(state);
    }

    public void turnLightsOn()
    {
        for (int i = 0; i < linkedLights.Length; i++)
            linkedLights[i].SetActive(true);
        lightState = true;
    }

    public void turnLightsOff()
    {
        for (int i = 0; i < linkedLights.Length; i++)
            linkedLights[i].SetActive(false);
        lightState = false;
    }

    public void flipSwitch()
    {
        gameEvents.current.lightSwitchFlipped();
        switchSFX.Play();
        lightState = !lightState;
        for (int i = 0; i < linkedLights.Length; i++)
            linkedLights[i].SetActive(lightState);
    }
}
