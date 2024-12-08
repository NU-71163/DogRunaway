using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBreak : MonoBehaviour
{
    public GameObject objectC;
    public GameObject objectD;
    public GameObject objectE;

    private int collisionCount = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("EnemyCat"))
        {
            collisionCount++;
            
            switch (collisionCount)
            {
                case 1:
                    Destroy(objectC);
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
                    break;
                default:
                    break;
            }
        }
        else if(other.gameObject.CompareTag("EnemyDog"))
        {
            collisionCount++;

            switch (collisionCount)
            {
                case 1:
                    Destroy(objectC);
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
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
                    break;
                case 2:
                    Destroy(objectD);
                    break;
                case 3:
                    Destroy(objectE);
                    break;
                default:
                    break;
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
