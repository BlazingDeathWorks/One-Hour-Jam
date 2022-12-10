using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAbility : Ability
{
    [SerializeField] private float _timeScale = 0.5f;
    [SerializeField] private float _slowRate = 3;

    private IEnumerator ResetTimeScale()
    {
        yield return new WaitForSecondsRealtime(_slowRate);
        Time.timeScale = 1;
    }

    protected override void Unleash()
    {
        Time.timeScale = _timeScale;
        StartCoroutine(ResetTimeScale());
    }
}
