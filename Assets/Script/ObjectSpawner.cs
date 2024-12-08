using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform spawnPosition;
    public Canvas targetCanvas;

    AudioSource audioSource;
    public AudioClip[] sound;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 9; i++)
        {
            if(Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha1 + i)) )
            {
                SpawnObject(i);
            }
        }
    }
    
    void SpawnObject(int index)
    {
        if(index >= 0 && index < prefabs.Length && prefabs[index] != null)
        {
            // �v���n�u�𐶐�
            GameObject newObject = Instantiate(prefabs[index], spawnPosition.position, Quaternion.identity);

            // Canvas�ɒǉ�
            if (targetCanvas != null)
            {
                newObject.transform.SetParent(targetCanvas.transform, false);

                // RectTransform�ňʒu��ݒ�
                RectTransform rectTransform = newObject.GetComponent<RectTransform>();
                if (rectTransform != null)
                {
                    rectTransform.anchoredPosition = spawnPosition.GetComponent<RectTransform>().anchoredPosition;
                }
            }
            audioSource.PlayOneShot(sound[index]);
        }
        else
        {
            Debug.LogWarning("�w�肳�ꂽ�C���f�b�N�X�̃v���n�u���ݒ肳��Ă��Ȃ����͈͊O�ł�: " + index);
        }
    }
}
