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
    }
}
