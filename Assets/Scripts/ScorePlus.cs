using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlus : MonoBehaviour
{
    public int plusPower;
    public float lifeSpan;
    public float speed;

    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);

        Destroy(gameObject, lifeSpan);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
