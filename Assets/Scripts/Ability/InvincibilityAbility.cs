using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityAbility : Ability
{
    [SerializeField] private float _invincibilityRate;

    protected override void Unleash()
    {
        PlayerAbilityManager.Instance.HidePlayerColliderWithEnemy(_invincibilityRate);
    }
}
