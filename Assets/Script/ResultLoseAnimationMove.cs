using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultLoseAnimationMove : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Lose()
    {
        anim.SetBool("Lose", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
