using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreScore;
    public int number1Score = 0;
    public int number2Score = 0;
    public int number3Score = 0;

    public Text number1ScoreText;
    public Text number2ScoreText;
    public Text number3ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number3Score = scoreScore;
        if(number1Score <= number3Score)
        {
            number1Score = number3Score;
            UpdateScoreText();
        }
        else if(number2Score <= number3Score)
        {
            number2Score = number3Score;
            UpdateScoreText();
        }
        else
        {
            UpdateScoreText();
        }
    }

    public void UpdateScoreText()
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
}
