using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreSystem : MonoBehaviour
{
    public static scoreSystem instance;

    [Header("Score System")]

    //Keeps track of Player 1's Current Score
    [SerializeField] private TextMeshProUGUI p1CurrentScoreText;

    //Keeps the record of the Highest Score of each player
    [SerializeField] private TextMeshProUGUI p1HighscoreText;

    private int p1Score;

    [Space(20)]

    //Keeps track of Player 2's Current Score
    [SerializeField] private TextMeshProUGUI p2CurrentScoreText;

    //Keeps the record of the Highest Score of each player
    [SerializeField] private TextMeshProUGUI p2HighscoreText;

    private int p2Score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        //Player 1 Score and Highscore

        p1CurrentScoreText.text = p1Score.ToString();

        p1HighscoreText.text = PlayerPrefs.GetInt("p1Highscore", 0).ToString();

        //Player 2 Score and Highscore

        p2CurrentScoreText.text = p2Score.ToString();

        p2HighscoreText.text = PlayerPrefs.GetInt("p2Highscore", 0).ToString();

        //Updates Highscore
        highscoreUpdateP1();
        highscoreUpdateP2();
    }

    void highscoreUpdateP1()
    {
        //Player 1 Highscore

        if (p1Score > PlayerPrefs.GetInt("p1Highscore"))
        {
            PlayerPrefs.SetInt("p1Highscore", p1Score);
            p1HighscoreText.text = p1Score.ToString();
        }
    }

    void highscoreUpdateP2()
    {
        //Player 2 Highscore

        if (p2Score > PlayerPrefs.GetInt("p2Highscore"))
        {
            PlayerPrefs.SetInt("p2Highscore", p2Score);
            p2HighscoreText.text = p2Score.ToString();
        }
    }

    public void scoreUpdateP1()
    {
        p1Score++;
        p1CurrentScoreText.text = p1Score.ToString();
        highscoreUpdateP1();
    }

    public void scoreUpdateP2()
    {
        p2Score++;
        p2CurrentScoreText.text = p2Score.ToString();
        highscoreUpdateP2();
    }
}
