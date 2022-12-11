using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int totalScore;

    private float time;
    private float score;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        totalScore = (int)time + (int)score;

        scoreText.text = totalScore.ToString();
    }

    public void ScorePlus(float plus)
    {
        score += plus;
    }
}