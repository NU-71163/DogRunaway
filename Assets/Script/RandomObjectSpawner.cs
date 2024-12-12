using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public float initialSpawnInterval = 2.0f; // ���������Ԋu
    public float minimumSpawnInterval = 0.5f; // �ŏ������Ԋu
    private float spawnInterval;

    // �������x���グ��Ԋu�i�b�j
    public float speedIncreaseInterval = 10.0f;

    // �������x���グ���
    public float spawnIntervalDecreaseAmount = 0.1f;

    public Transform spawnPosition;

    private Coroutine spawnCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        // ���������Ԋu��ݒ�
        spawnInterval = initialSpawnInterval;

        // �����������J�n
        StartSpawning();

        // �������x���グ�鏈�����J�n
        StartCoroutine(IncreaseSpawnSpeedOverTime());
    }

    public void StartSpawning()
    {
        if (spawnCoroutine == null)
        {
            spawnCoroutine = StartCoroutine(SpawnObjects());
        }
    }

    public void StopSpawning()
    {
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = null;
        }
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            // �����_���Ƀv���n�u��I��
            int randomIndex = Random.Range(0, prefabs.Length);

            // �v���n�u���ݒ肳��Ă��邩�m�F
            if (prefabs[randomIndex] != null)
            {
                // �v���n�u�𐶐�
                Instantiate(prefabs[randomIndex], spawnPosition.position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("�����_���ɑI�΂ꂽ�C���f�b�N�X�̃v���n�u���ݒ肳��Ă��܂���: " + randomIndex);
            }

            // ���̐����܂őҋ@
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    IEnumerator IncreaseSpawnSpeedOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(speedIncreaseInterval);

            // �����Ԋu�������i�������x���グ��j
            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - spawnIntervalDecreaseAmount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
