using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObjectMover : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 左（x軸のマイナス方向）に移動
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
