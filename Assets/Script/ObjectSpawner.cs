using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform spawnPosition;
    
    AudioSource audioSource;
    public AudioClip[] sound;

    public meter[] meters;

    private bool[] keyPressed;

    public int maxSummonCount;
    public int summonCount;

    public Image[] UIobj;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        keyPressed = new bool[9];
        for (int i = 0; i < keyPressed.Length; i++)
        {
            keyPressed[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (maxSummonCount >= summonCount && summonCount != 0)
        {
            for (int i = 0; i < 9; i++)
            {
                // �Y���L�[��������A���܂�������Ă��Ȃ��ꍇ
                if (Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha1 + i)) && !keyPressed[i])
                {
                    SpawnObject(i);
                    if (i < meters.Length && meters[i] != null)
                    {
                        StartCoroutine(meters[i].ReduceFillAmount(i));
                    }

                    // �����ꂽ�L�[�𖳌���
                    keyPressed[i] = true;
                    summonCount -= 1;
                }
            }
        }
        else if (summonCount == 0)
        {
            KeyLock();
        }
    }
    
    void SpawnObject(int index)
    {
        if(index >= 0 && index < prefabs.Length && prefabs[index] != null)
        {
            GameObject newObject = Instantiate(prefabs[index], spawnPosition.position, Quaternion.identity);
            audioSource.PlayOneShot(sound[index]);
        }
        else
        {
            Debug.LogWarning("�w�肳�ꂽ�C���f�b�N�X�̃v���n�u���ݒ肳��Ă��Ȃ����͈͊O�ł�: " + index);
        }
    }

    public void EnableKey(int keyIndex)
    {
        if (keyIndex >= 0 && keyIndex < keyPressed.Length)
        {
            keyPressed[keyIndex] = false; // �L�[��L����
        }
    }

    public void KeyLock()
    {
        for (int i = 0; i < 9; i++)
        {
            keyPressed[i] = true;
        }
    }

    public void HealSummonCount()
    {
        summonCount += 1;
        for (int i = 0; i < 9; i++)
        {
            if (!UIobj[i].enabled) // UIobj�������Ȃ�AReduceFillAmount���I���������Ƃ��Ӗ����܂�
            {
                for (int j = 0; j < 9; j++)
                {
                    keyPressed[j] = false;
                }
            }
        }
    }
}
