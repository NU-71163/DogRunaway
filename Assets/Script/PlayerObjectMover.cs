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
        //�E�ix���̃v���X�̕����j�Ɉړ�
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
