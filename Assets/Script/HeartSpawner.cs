using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    public GameObject gameObject;

    public int numberofObjects = 3;

    public float xOffset = 2.0f;

    public Transform spawnStartPoint;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for(int i = 0; i < numberofObjects; i++)
        {
            Vector3 spawnPosition = spawnStartPoint.position + new Vector3(xOffset * i, 0, 0);

            Instantiate(gameObject, spawnPosition, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
