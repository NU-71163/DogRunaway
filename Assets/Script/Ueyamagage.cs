using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ueyamagage : MonoBehaviour
{
    [SerializeField] Slider DashGage;

    public float maxGageValue; //�Q�[�W�̍ő�l
    public float gageIncreaseValue; //�Q�[�W�̉񕜗�
    float currentGageValue; //���݂̃Q�[�W�̒l

    public AudioClip ueyamaGage;
    AudioSource audioSource;

    public Text ueyamaText;

    // Start is called before the first frame update
    void Start()
    {
        DashGage.maxValue = maxGageValue;
        DashGage.value = 0;

        audioSource = GetComponent<AudioSource>();
        ueyamaText.gameObject.SetActive(false); // �e�L�X�g���\��
    }

    // Update is called once per frame
    public void GageUp()
    {
        if(currentGageValue < maxGageValue)
        {
            currentGageValue += gageIncreaseValue;
            DashGage.value = currentGageValue;

            if(currentGageValue == maxGageValue)
            {
                ueyamaText.gameObject.SetActive(true); // �e�L�X�g��\��
                audioSource.PlayOneShot(ueyamaGage);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && currentGageValue == maxGageValue)
        {
            SoundBox soundBox = GameObject.Find("SoundManager2").GetComponent<SoundBox>();
            if (soundBox != null)
            {
                soundBox.score += 100;
                GameObject soundObject = GameObject.Find("SoundManager2");
                if (soundObject != null)
                {
                    SoundBox soundBoxScript = soundObject.GetComponent<SoundBox>();
                    if (soundObject != null)
                    {
                        soundBoxScript.UpdateScoreText();
                    }
                }
            }

            GameObject animationObject = GameObject.Find("�K�E");
            if (animationObject != null)
            {
                Debug.Log("a");
                AnimationMove animationScript = animationObject.GetComponent<AnimationMove>();
                if (animationScript != null)
                {
                    animationScript.hissatu();
                }
            }

            ueyamaText.gameObject.SetActive(false);
            currentGageValue = 0;
            DashGage.value = currentGageValue;
        }
    }
}
