using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour
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

    // Update is called once per frame
    public void hissatu()
    {
        anim.SetBool("Swith", true);
        audioSource.PlayOneShot(sound1);
    }

   public void OnAnimationEnd()
    {
        anim.SetBool("Swith", false);
    }
}
