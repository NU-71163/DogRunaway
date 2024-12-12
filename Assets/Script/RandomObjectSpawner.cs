using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public float initialSpawnInterval = 2.0f; // 初期生成間隔
    public float minimumSpawnInterval = 0.5f; // 最小生成間隔
    private float spawnInterval;

    // 生成速度を上げる間隔（秒）
    public float speedIncreaseInterval = 10.0f;

    // 生成速度を上げる量
    public float spawnIntervalDecreaseAmount = 0.1f;

    public Transform spawnPosition;

    private Coroutine spawnCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        // 初期生成間隔を設定
        spawnInterval = initialSpawnInterval;

        // 自動生成を開始
        StartSpawning();

        // 生成速度を上げる処理を開始
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
            // ランダムにプレハブを選択
            int randomIndex = Random.Range(0, prefabs.Length);

            // プレハブが設定されているか確認
            if (prefabs[randomIndex] != null)
            {
                // プレハブを生成
                Instantiate(prefabs[randomIndex], spawnPosition.position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("ランダムに選ばれたインデックスのプレハブが設定されていません: " + randomIndex);
            }

            // 次の生成まで待機
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    IEnumerator IncreaseSpawnSpeedOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(speedIncreaseInterval);

            // 生成間隔を減少（生成速度を上げる）
            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - spawnIntervalDecreaseAmount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
