using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTime = 180f; // �^�C�}�[�̏������ԁi�b�j
    public float currentTime;

    public Text timerText; // UI�e�L�X�g�i���ԕ\���p�j
    public bool timerRunning = false; // �^�C�}�[�̏��

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
                currentTime -= Time.deltaTime; // �o�ߎ��Ԃ����炷
                UpdateTimerUI(); // UI���X�V
            }
            else
            {
                timerRunning = false; // �^�C�}�[���~
                currentTime = 0; // ���Ԃ����Z�b�g
                UpdateTimerUI();
            }
        }
    }

    public void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = currentTime.ToString("F0"); // �����_�ȉ�1���܂ŕ\��
        }

        if(currentTime == 0)
        {
            WinAnimation();
            GameObject soundObject = GameObject.Find("SoundManager2");
            if(soundObject != null)
            {
                SoundBox soundBoxScript = soundObject.GetComponent<SoundBox>();
                if(soundBoxScript != null)
                {
                    soundBoxScript.FinalScoreText();
                }
            }
        }
    }
    
    public void WinAnimation()
    {
        GameObject resultWinAnimationObject = GameObject.Find("���ʁi�����j");
        if (resultWinAnimationObject != null)
        {
            ResultWinAnimationMove resultWinAnimationScript = resultWinAnimationObject.GetComponent<ResultWinAnimationMove>();
            if (resultWinAnimationScript != null)
            {
                resultWinAnimationScript.Win();
            }
        }

        GameObject spawnObject = GameObject.Find("ObjectSpawner");
        if (spawnObject != null)
        {
            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
            if (spawnScript != null)
            {
                spawnScript.KeyLock();
            }
        }

        GameObject heartObject = GameObject.Find("���i�����j");
        if (heartObject != null)
        {
            HeartBreak heartScript = heartObject.GetComponent<HeartBreak>();
            if (heartScript != null)
            {
                heartScript.DisableOnCollisionEnter2D();
            }
        }
    }
}
