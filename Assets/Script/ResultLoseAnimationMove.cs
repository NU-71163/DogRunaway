using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultLoseAnimationMove : MonoBehaviour
{
    private Animator anim;
    public AudioClip sound1;
    AudioSource audioSource;

    public bool isLoseCalled = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public bool Lose()
    {
        anim.SetBool("Lose", true);
        isLoseCalled = true; // ŒÄ‚Î‚ê‚½‚±‚Æ‚ð‹L˜^
        return isLoseCalled;
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
