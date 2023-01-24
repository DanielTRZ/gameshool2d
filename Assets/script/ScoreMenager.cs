using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenager : MonoBehaviour
{

    public static ScoreMenager instance;
    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Rekord", 0);
        scoreText.text =  "Zebrane Diamenty " + score.ToString();
        highscoreText.text = "Rekord: " + highscore.ToString();
    }

    // Update is called once per frame
   public void AddPoint()
    {
        score += 1;
        scoreText.text = "Zebrane Diamenty " + score.ToString();

        if (highscore < score)
        {
            PlayerPrefs.SetInt("Rekord", score);
        }

    }
}
