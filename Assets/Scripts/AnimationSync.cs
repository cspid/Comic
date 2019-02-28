using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSync : MonoBehaviour

{
    //public Animator[] animators;
    public Animator br_Body;
    public Animator br_Ball;
    public float timer = 3;
    float startTime;
    bool play;
    public float ballOffset;

    void Start()
    {
        startTime = timer;
    }

    void Update()
    {
        if (play == true)
        {
            if (null != br_Body)
            {
                print( "adsdfs");
                // play Bounce but start at a quarter of the way though
                br_Body.Play("BallBounce", 0, 0);
            }

            if (null != br_Ball)
            {
                // play Bounce but start at a quarter of the way though
                br_Ball.Play("tennisBallCopy", 0, ballOffset);
            }
            play = false;
        }
        
timer -= Time.deltaTime;
        if (timer < 0)
        {
            play = true;
            timer = startTime;
        }
    }
}