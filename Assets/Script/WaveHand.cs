using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHand : MonoBehaviour
{
    public float animationTime = 5.0f;
    private float thisTime = 0f;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        thisTime += Time.deltaTime;
        if(thisTime >= animationTime)
        {
            thisTime = 0f;
            animator.SetTrigger("Wave");
        }
    }
}
