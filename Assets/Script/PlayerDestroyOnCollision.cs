using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyOnCollision : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyTower")
        {
            Destroy(gameObject);
            Timer timer = GameObject.Find("TimeManager").GetComponent<Timer>();
            if (timer != null)
            {
                timer.currentTime -= 5;
                GameObject timeObject = GameObject.Find("TimeManager");
                if (timeObject != null)
                {
                    Timer timerScript = timeObject.GetComponent<Timer>();
                    if (timeObject != null)
                    {
                        timerScript.UpdateTimerUI();
                    }
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
