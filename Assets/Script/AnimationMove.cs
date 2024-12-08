using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour
{
    private Animator anim;
    public GameObject parentObject;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        parentObject.SetActive(false);
    }

    // Update is called once per frame
    public void hissatu()
    {
        parentObject.SetActive(true);
        anim.SetBool("Swith", true);
    }
}
