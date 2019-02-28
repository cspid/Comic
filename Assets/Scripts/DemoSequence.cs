using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DemoSequence : MonoBehaviour
{
    public lerpRectTranform openL;
    public lerpRectTranform openBR;
    public lerpRectTranform openT;
    public lerpRectTranform openBL;
    public SpeechBubbleSwitch bubble;


    public int counter = 0;
    bool callLerp;
    int counterLastFrame;
    public ballStop stop;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            counter++;
        }
        if (counter > counterLastFrame)
        {
            if (counter == 1)
            {
             //   openL.isLerping = true;
                openT.isLerping = true;
                bubble.isSpeech = true;

}


            if (counter == 2)
            {
                openBR.isLerping = true;
            }


            if (counter == 3)
            {
                //Kill the ball and
                stop.active = true;

            }


            if (counter == 4)
            {
                // open new frame
                openBL.isLerping = true;
            }
        }
        counterLastFrame = counter; 
    }
}
