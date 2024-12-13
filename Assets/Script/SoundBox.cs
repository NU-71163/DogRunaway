using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBox : MonoBehaviour
{
    public int SoundCount = 0;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;
    AudioSource audioSource;

    public Text scoreText;
    public Text finalText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = 0;
        UpdateScoreText();
    }

    public void Sound()
    {
        SoundCount++;
        if (SoundCount >= 8)
        {
            SoundCount = 8;
        }

        switch (SoundCount)
        {
            case 1:
                audioSource.PlayOneShot(sound1);
                score += 1;
                UpdateScoreText();
                break;
            case 2:
                audioSource.PlayOneShot(sound2);
                score += 2;
                UpdateScoreText();
                break;
            case 3:
                audioSource.PlayOneShot(sound3);
                score += 3;
                UpdateScoreText();
                break;
            case 4:
                audioSource.PlayOneShot(sound4);
                score += 4;
                UpdateScoreText();
                break;
            case 5:
                audioSource.PlayOneShot(sound5);
                score += 5;
                UpdateScoreText();
                break;
            case 6:
                audioSource.PlayOneShot(sound6);
                score += 6;
                UpdateScoreText();
                break;
            case 7:
                audioSource.PlayOneShot(sound7);
                score += 7;
                UpdateScoreText();
                break;
            case 8:
                audioSource.PlayOneShot(sound8);
                score += 8;
                UpdateScoreText();
                break;
            default:
                break;
        }
    }

    public void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "スコア: " + score.ToString();
        }
    }

    public void FinalScoreText()
    {
        if (scoreText != null)
        {
            finalText.text = "スコア: " + score.ToString();
        }
    }

    public void ScoreSwitch()
    {
        Score.scoreScore = score;
    }
    // Update is called once per frame
    void Update()
    {
 
    }
}
