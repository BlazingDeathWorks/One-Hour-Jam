using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public int TotalScore { get; set; }

    private float time;
    private float score;

    public TextMeshPro scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        TotalScore = (int)time + (int)score;

        scoreText.text = TotalScore.ToString();
    }

    public void ScorePlus(float plus)
    {
        score += plus;
    }
}
