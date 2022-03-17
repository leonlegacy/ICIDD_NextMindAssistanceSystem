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

    private void Start()
    {
        StartCoroutine(expStart());
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
        LeanTween.moveLocalY(SpotLightsSet, 2f, 4f);
        yield return new WaitForSeconds(2);

        LeanTween.moveLocalZ(WindowedWall, 0, 3f);
        yield return new WaitForSeconds(2);
    }

    IEnumerator closeWindowsIE()
    {
        yield return new WaitForSeconds(1);
    }
}
