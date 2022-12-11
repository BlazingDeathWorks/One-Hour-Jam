using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAbility : Ability
{
    [SerializeField] private float _shrinkScale = 0.8f;
    [SerializeField] private float _shrinkRate;

    protected override void Unleash()
    {
        PlayerAbilityManager.Instance?.ShrinkPlayer(_shrinkScale, _shrinkRate);
    }

}
