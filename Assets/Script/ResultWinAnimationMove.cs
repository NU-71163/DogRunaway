using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultWinAnimationMove : MonoBehaviour
{
    private Animator anim;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Win()
    {
        anim.SetBool("Win", true);
        GameObject soundBoxObject = GameObject.Find("SoundManager2");
        if (soundBoxObject != null)
        {
            SoundBox soundBoxScript = soundBoxObject.GetComponent<SoundBox>();
            if (soundBoxScript != null)
            {
                soundBoxScript.ScoreSwitch();
            }
        }
    }

    public void OnAnimationSound()
    {
        audioSource.PlayOneShot(sound1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
