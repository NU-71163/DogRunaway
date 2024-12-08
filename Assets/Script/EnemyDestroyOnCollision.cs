using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDestroyOnCollision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D other)
   {
        if (other.gameObject.tag == "PlayerTower")
        {
            Destroy(gameObject);
            SoundBox soundBox = GameObject.Find("SoundManager2").GetComponent<SoundBox>();
            if (soundBox != null)
            {
                soundBox.SoundCount = 0;
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
