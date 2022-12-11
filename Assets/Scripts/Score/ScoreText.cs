using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Awake()
    {
        _scoreText.text = $"Score: {GameManager.Instance?.PersistScore.ToString()}";
    }
}
