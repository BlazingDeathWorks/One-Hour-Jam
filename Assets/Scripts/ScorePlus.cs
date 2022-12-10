using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePlus : MonoBehaviour
{
    public int plusPower;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
