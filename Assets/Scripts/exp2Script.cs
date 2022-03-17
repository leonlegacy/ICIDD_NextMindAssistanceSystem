using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp2Script : MonoBehaviour
{
    [SerializeField]
    GameObject NormalWall, WindowedWall, Windows, SpotLightsSet;

    [Header("SFXs")]

    [SerializeField]
    AudioSource MachineSFX;
    [SerializeField]
    AudioSource WindowSFX;
    [SerializeField]
    AudioSource spotlightSFX;

    [Header("Lights Animator")]
    [SerializeField]
    Animator[] lights;

    private void Start()
    {
        StartCoroutine(expStart());
        //gameEvents.current.onWindowTrigger += closeWindows;
    }

    public void closeWindows()
    {
        LeanTween.moveLocalY(Windows, 0, 2f);
        WindowSFX.Play();
    }

    IEnumerator expStart()
    {
        
        yield return new WaitForSeconds(1);
        MachineSFX.Play();
        LeanTween.moveLocalY(NormalWall, -3f, 2f);
        yield return new WaitForSeconds(3);

        LeanTween.moveLocalZ(WindowedWall, 0.5f, 0.1f);
        LeanTween.moveLocalY(WindowedWall, 0, 2.5f);
        LeanTween.moveLocalY(SpotLightsSet, 2.6f, 4f);
        yield return new WaitForSeconds(2);

        LeanTween.moveLocalZ(WindowedWall, 0, 3f);
        yield return new WaitForSeconds(4);

        spotlightSFX.Play();
        for (int i = 0; i < lights.Length; i++)
            lights[i].Play("heavyLightOn");
    }

    IEnumerator closeWindowsIE()
    {
        yield return new WaitForSeconds(1);
    }

    private void OnDestroy()
    {
        //gameEvents.current.onWindowTrigger -= closeWindows;
    }
}
