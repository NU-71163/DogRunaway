using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreScore;
    public static int number1Score = 0;
    public static int number2Score = 0;
    public static int number3Score = 0;

    public static Text number1ScoreText;
    public static Text number2ScoreText;
    public static Text number3ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        number1ScoreText = GameObject.Find("number1Score").GetComponent<Text>();
        number2ScoreText = GameObject.Find("number2Score").GetComponent<Text>();
        number3ScoreText = GameObject.Find("number3Score").GetComponent<Text>();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }

    public static void UpdateScoreText()
    {
        if (number1ScoreText != null)
        {
            number1ScoreText.text = "‚PˆÊ: " + number1Score.ToString();
        }
        if (number2ScoreText != null)
        {
            number2ScoreText.text = "‚QˆÊ: " + number2Score.ToString();
        }
        if (number3ScoreText != null)
        {
            number3ScoreText.text = "‚RˆÊ: " + number3Score.ToString();
        }
    }

    public static void mendoi()
    {
        if (number1Score <= scoreScore)
        {
            number2Score = number1Score;
            number1Score = scoreScore;
            UpdateScoreText();
        }
        else if (number2Score <= scoreScore)
        {
            number3Score = number2Score;
            number2Score = scoreScore;
            UpdateScoreText();
        }
        else if (number3Score <= scoreScore)
        {
            UpdateScoreText();
        }
    }
}
