using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationControl : MonoBehaviour {

    private Animator anim;
    public Slider m_slider;
    float timeAnim;
    bool animIsFinished;
    private AudioSource buildSFX;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.speed = 0;
        animIsFinished = false;
        buildSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!animIsFinished && anim.GetCurrentAnimatorStateInfo(0).IsName("BuildAnim"))
        {
            m_slider.value = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
            if (!buildSFX.isPlaying)
            {
                buildSFX.Play();
            }
        }

        timeAnim = (int)anim.GetCurrentAnimatorStateInfo(0).normalizedTime * anim.GetCurrentAnimatorStateInfo(0).length;

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("BuildAnim") && timeAnim >= anim.GetCurrentAnimatorStateInfo(0).length)
        {
            animIsFinished = true;
        }

        if (animIsFinished && anim.GetCurrentAnimatorStateInfo(0).IsName("BuildAnim"))
        {
            if (buildSFX.isPlaying)
            {
                buildSFX.Stop();
            }
            anim.Play("BuildAnim", 0, m_slider.value);
        }
    }
}
