using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerToo : MonoBehaviour
{
    //GameManager a;
    public static ScoreManagerToo instances;

    public Text scoreText;
    public Text highscoreText;

    int score2 = 0;
    int highscore2 = 0;

    void Awake()
    {
       instances = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore2 = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score2.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore2.ToString();
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score2 += 1;
        scoreText.text = score2.ToString() + " POINTS";
        if (highscore2 < score2)
        PlayerPrefs.SetInt("highscore", score2);
    }
}
