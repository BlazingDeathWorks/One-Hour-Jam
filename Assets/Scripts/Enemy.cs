using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        transform.Translate(transform.right * _speed * Time.deltaTime);
    }
}
