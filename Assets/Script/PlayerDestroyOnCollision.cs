using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyOnCollision : MonoBehaviour
{
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
                if (spawnObject != null)
                {
                    spawnScript.HealSummonCount();
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
