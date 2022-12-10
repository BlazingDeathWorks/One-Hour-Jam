using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public static AbilityManager Instance { get; private set; }
    public Ability Powerup { private get; set; } = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }

    private void Update()
    {
        if (Powerup == null) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Powerup.Unleash();
        }
    }
}
