using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlusSpawner : MonoBehaviour
{
    [SerializeField] private ScorePlus[] scorePlus;

    [SerializeField] private Vector2 spawnRange;

    private float spawnTime;
    [SerializeField] private float spawnSpeed;

    void Start()
    {
        spawnTime = spawnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Instantiate(scorePlus[Random.Range(0, scorePlus.Length)], new Vector3(Random.Range(-spawnRange.x, spawnRange.x), Random.Range(-spawnRange.y, spawnRange.y), 0), transform.rotation);

            spawnTime = spawnSpeed;
        }
    }
}
