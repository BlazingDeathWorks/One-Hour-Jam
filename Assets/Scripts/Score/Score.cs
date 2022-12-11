using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public Player player;

    public int totalScore;

    private float time;
    private float score;

    public TextMeshPro scoreText;

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

    // Update is called once per frame
    void Update()
    {
        if (player.dead == false)
        {
            time += Time.deltaTime;
        }

        totalScore = (int)time + (int)score;

        scoreText.text = totalScore.ToString();
    }

    public void ScorePlus(float plus)
    {
        score += plus;
    }
}
