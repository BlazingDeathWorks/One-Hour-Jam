using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    //Rotation Enemy should be facing when going straight relative to the spawner
    [SerializeField] private float _straightAngle;
    //This will be plus minus variation from striaght angle
    [SerializeField] private float _angleVariationRange;
    [SerializeField] private float _spawnRate = 1;
    private float _timeSinceLastSpawned = 0;

    private void Awake()
    {
        _timeSinceLastSpawned = _spawnRate;
    }

    private void Update()
    {
        if (_enemy == null) return;

        _timeSinceLastSpawned += Time.deltaTime;
        if (_timeSinceLastSpawned >= _spawnRate)
        {
            Transform enemyTransform = Instantiate(_enemy, transform.position, Quaternion.identity).transform;
            enemyTransform.localEulerAngles = new Vector3(0, 0, _straightAngle + Random.Range(-_angleVariationRange, _angleVariationRange));
            enemyTransform.parent = transform;
            _timeSinceLastSpawned = 0;
        }
    }
}
