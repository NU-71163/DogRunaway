using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public Transform spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(prefabs[index], spawnPosition.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("指定されたインデックスのプレハブが設定されていないか範囲外です: " + index);
        }
    }
}
