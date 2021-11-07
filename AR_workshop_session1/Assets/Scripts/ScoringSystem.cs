using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField]
    private int score;

    [SerializeField]
    private int hp;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text hpText;

    void Start()
    {
        score = 0;
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        hpText.text = "HP: " + hp.ToString();
    }

    public void AddScore()
    {
        score += 10;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void TakeDamage()
    {
        if (hp > 0)
        {
            hp -= 10;
        }
    }
}
