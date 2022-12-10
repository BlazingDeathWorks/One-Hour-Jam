using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAbility : Ability
{
    [SerializeField] private float _shrinkScale = 0.8f;
    private Transform _playerTransform;

    private void Awake()
    {
        _playerTransform = GameObject.Find("Player").transform;
    }

    protected override void Unleash()
    {
        if (_playerTransform == null) return;

        _playerTransform.localScale = new Vector3(_shrinkScale, _shrinkScale, _shrinkScale);
    }

}
