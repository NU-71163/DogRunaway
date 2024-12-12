using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyOnCollision : MonoBehaviour
{
    private ResultLoseAnimationMove resultLoseAnimationMove;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ResultLoseAnimationMove resultLoseAnimationMoveInstance = FindObjectOfType<ResultLoseAnimationMove>();

        if (other.gameObject.tag == "EnemyTower")
        {
            Destroy(gameObject);
            GameObject spawnObject = GameObject.Find("ObjectSpawner");
            if (spawnObject != null)
            {
                ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                if (spawnObject != null && !resultLoseAnimationMove.isLoseCalled)
                {
                    spawnScript.HealSummonCount();
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        resultLoseAnimationMove = GameObject.FindObjectOfType<ResultLoseAnimationMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
