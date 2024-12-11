using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowDestroyOnCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyPig")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            GameObject ueyamaObject = GameObject.Find("SliderManager");
            if (ueyamaObject != null)
            {
                Ueyamagage ueyamagageScript = ueyamaObject.GetComponent<Ueyamagage>();
                if (ueyamagageScript != null)
                {
                    ueyamagageScript.GageUp();
                }
            }

            GameObject SoundObject = GameObject.Find("SoundManager2");
            if (SoundObject != null)
            {
                SoundBox soundBoxScript = SoundObject.GetComponent<SoundBox>();
                if (soundBoxScript != null)
                {
                    soundBoxScript.Sound();
                }
            }

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
        else if (other.gameObject.tag == "EnemyCrane")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            GameObject ueyamaObject = GameObject.Find("SliderManager");
            if (ueyamaObject != null)
            {
                Ueyamagage ueyamagageScript = ueyamaObject.GetComponent<Ueyamagage>();
                if (ueyamagageScript != null)
                {
                    ueyamagageScript.GageUp();
                }
            }

            GameObject SoundObject = GameObject.Find("SoundManager2");
            if (SoundObject != null)
            {
                SoundBox soundBoxScript = SoundObject.GetComponent<SoundBox>();
                if (soundBoxScript != null)
                {
                    soundBoxScript.Sound();
                }
            }

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
