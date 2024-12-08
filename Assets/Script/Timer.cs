using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 180f; // タイマーの初期時間（秒）
    public float currentTime;

    public Text timerText; // UIテキスト（時間表示用）
    public bool timerRunning = false; // タイマーの状態

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
        UpdateTimerUI();
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime; // 経過時間を減らす
                UpdateTimerUI(); // UIを更新
            }
            else
            {
                timerRunning = false; // タイマーを停止
                currentTime = 0; // 時間をリセット
                UpdateTimerUI();
            }
        }
    }

    public void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = currentTime.ToString("F0"); // 小数点以下1桁まで表示
        }
    }
}
