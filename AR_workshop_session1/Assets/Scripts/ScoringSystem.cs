using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField]
    private int score;

    [SerializeField]
    private Text scoreText;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore()
    {
        score += 10;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
