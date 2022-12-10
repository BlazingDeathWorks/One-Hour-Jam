using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAbility : Ability
{
    [SerializeField] private float _timeScale = 0.5f;
    [SerializeField] private float _slowRate = 3;

    protected override void Unleash()
    {
        TimeManager.Instance.SlowTime(_timeScale, _slowRate);
    }
}
