using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ueyamagage : MonoBehaviour
{
    [SerializeField] Slider DashGage;

    public float maxGageValue; //ゲージの最大値
    public float gageIncreaseValue; //ゲージの回復量
    float currentGageValue; //現在のゲージの値

    public AudioClip ueyamaGage;
    AudioSource audioSource;

    public Text ueyamaText;

    // Start is called before the first frame update
    void Start()
    {
        DashGage.maxValue = maxGageValue;
        DashGage.value = 0;

        audioSource = GetComponent<AudioSource>();
        ueyamaText.gameObject.SetActive(false); // テキストを非表示
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
                ueyamaText.gameObject.SetActive(true); // テキストを表示
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

            GameObject animationObject = GameObject.Find("必殺");
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
