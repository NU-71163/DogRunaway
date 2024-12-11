using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBreak : MonoBehaviour
{
    public GameObject objectC;
    public GameObject objectD;
    public GameObject objectE;

    public AudioClip sound1;
    AudioSource audioSource;

    public int collisionCount = 0;

    private bool isActive = true;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(isActive)
        {
            if (other.gameObject.CompareTag("EnemyCat"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyDog"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyCrab"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyCrane"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyMonkey"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyTurtle"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyPig"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyCow"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (other.gameObject.CompareTag("EnemyRabbit"))
            {
                collisionCount++;

                switch (collisionCount)
                {
                    case 1:
                        Destroy(objectC);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 2:
                        Destroy(objectD);
                        audioSource.PlayOneShot(sound1);
                        break;
                    case 3:
                        Destroy(objectE);
                        audioSource.PlayOneShot(sound1);

                        GameObject spawnObject = GameObject.Find("ObjectSpawner");
                        if (spawnObject != null)
                        {
                            ObjectSpawner spawnScript = spawnObject.GetComponent<ObjectSpawner>();
                            if (spawnScript != null)
                            {
                                spawnScript.KeyLock();
                            }
                        }

                        GameObject resultLoseanimationObject = GameObject.Find("åãâ ÅiîsñkÅj");
                        if (resultLoseanimationObject != null)
                        {
                            ResultLoseAnimationMove resultLoseanimationScript = resultLoseanimationObject.GetComponent<ResultLoseAnimationMove>();
                            if (resultLoseanimationScript != null)
                            {
                                resultLoseanimationScript.Lose();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void DisableOnCollisionEnter2D()
    {
        isActive = false;
        Debug.Log("FunctionB is now disabled.");
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
