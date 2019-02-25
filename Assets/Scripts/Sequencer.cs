using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : MonoBehaviour
{
    public Animator speech1;
    public Animator smallRoom1;
    public Animator smallRoom2;

    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    public void SpeechBubble1()
    {
        speech1.SetTrigger("Go");
    }

    public void SmallRoom1()
    {
        smallRoom1.SetTrigger("Go");
    }

    public void SmallRoom2()
    {
        smallRoom2.SetTrigger("Go");
    }
}
