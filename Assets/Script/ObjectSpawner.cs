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
        for (int i = 0; i < 9; i++)
        {
            // 該当キーが押され、かつまだ押されていない場合
            if (Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha1 + i)) && !keyPressed[i])
            {
                SpawnObject(i);
                if (i < meters.Length && meters[i] != null)
                {
                    StartCoroutine(meters[i].ReduceFillAmount(i));
                }

                // 押されたキーを無効化
                keyPressed[i] = true;
            }
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
            Debug.LogWarning("指定されたインデックスのプレハブが設定されていないか範囲外です: " + index);
        }
    }

    public void EnableKey(int keyIndex)
    {
        if (keyIndex >= 0 && keyIndex < keyPressed.Length)
        {
            keyPressed[keyIndex] = false; // キーを有効化
        }
    }

    public void KeyLock()
    {
        for (int i = 0; i < 9; i++)
        {
            keyPressed[i] = true;
        }
    }
}
