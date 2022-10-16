using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;

    private int score = 0;
    private int total = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        total = FindObjectsOfType<Collectible>().Length;
    }

    private void Update()
    {
        scoreText.text = $"{score}/{total}";

        if (score == total)
        {
            scoreText.text = "Return to the car";
        }
    }

    public void AddScore()
    {
        score++;
    }

    public bool CheckFinish()
    {
        return score == total;
    }
}
