using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    [SerializeField] private Vector2 _xMinMaxRange;
    [SerializeField] private Vector2 _yMinMaxRange;
    [SerializeField] private Ability[] _abilities;
    [SerializeField] private float _spawnRate = 1;
    private float _timeSinceLastSpawned = 0;

    private void Update()
    {
        if (_abilities.Length <= 0) return;

        _timeSinceLastSpawned += Time.deltaTime;
        if (_timeSinceLastSpawned >= _spawnRate)
        {
            _timeSinceLastSpawned = 0;
            Instantiate(_abilities[Random.Range(0, _abilities.Length)], transform.position, Quaternion.identity);
        }
    }
}
