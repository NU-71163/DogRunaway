using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectMover : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //右（x軸のプラスの方向）に移動
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
