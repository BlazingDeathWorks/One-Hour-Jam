using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Seconds / 600 (i.e. 60 / 600 = 0.1)
public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }
    [SerializeField] private float _changeRate = 60;
    private float _saveTimeScale;
    private float _timer;


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
        _timer += Time.deltaTime;
        if (_timer >= _changeRate)
        {
            _timer = 0;
            Time.timeScale += 0.1f;
        }
    }

    private IEnumerator ResetTime(float length)
    {
        yield return new WaitForSecondsRealtime(length);
        Time.timeScale = _saveTimeScale;
    }

    public void SlowTime(float value, float length)
    {
        _saveTimeScale = Time.timeScale;
        Time.timeScale = value;
        StartCoroutine(ResetTime(length));
    }
}
