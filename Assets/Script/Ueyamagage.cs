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

    // Start is called before the first frame update
    void Start()
    {
        DashGage.maxValue = maxGageValue;
        DashGage.value = 0;

        audioSource = GetComponent<AudioSource>();
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
                audioSource.PlayOneShot(ueyamaGage);
            }
        }
    }
}
