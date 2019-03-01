using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
public class DemoSequence : MonoBehaviour
{
    [Header("General")]

    public int counter = 0;
    public SpeechBubbleSwitch bubble;
    public GameObject scene1;
    public GameObject scene2;

    [Header("Scene 1")]
    public lerpRectTranform openL;
    public lerpRectTranform openBR;
    public lerpRectTranform openT;
    public lerpRectTranform openBL;
    public lerpRectTranform closeTitle;
    public lerpRectTranform closeT;
    public lerpRectTranform closeBR;
    public lerpRectTranform closeBL;
    public lerpRectTranform closeL;
    public Text textCounter;
    public GameObject frames;
    bool newSceneTrigger;
    public ballStop stop;
    float timer = 3;

    [Header("Scene 2")]
    public lerpRectTranform openL_S2;
    public lerpRectTranform openM_S2;
    public lerpRectTranform openR_S2;


    [Header("Yarn")]
    public DialogueRunner dialogueRunner;


    bool callLerp;
    int counterLastFrame;
    public ColorLerp colorLerp;

    // Update is called once per frame
    void Update()
    {
        if(newSceneTrigger == true)
        {
            NewScene();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            counter++;
        }

        if (counter > counterLastFrame)
        {
            textCounter.text = "" + counter;
            if (counter == 1)
            {
             // Open text  
                openT.isLerping = true;
                bubble.isSpeech = true;
                dialogueRunner.StartDialogue("Thesis_Start");
}
            if (counter == 2)
            {
                //Open BR
               openBR.isLerping = true;
               closeTitle.isLerping = true;
            }

            if (counter == 3)
            {
                //dialogue
            }

            if (counter == 4)
            {
            }
            if (counter == 5)

            {               
                //Kill the ball and
                stop.active = true;
            }

            if (counter == 6)
            {
                // open new frame
                openBL.isLerping = true;
            }

            if (counter == 7)
            {
                // open new frame
                dialogueRunner.StartDialogue("Thesis_Scene_1B");
            }

            if (counter == 7)
            {
             
                bubble.isSpeech = true;
            }

            if (counter == 12)
            {
                //Shutdown scene 1
                closeT.isLerping = true;
                closeBL.isLerping = true;
                closeBR.isLerping = true;
                closeL.isLerping = true;
                newSceneTrigger = true;
                
            }
        }
        counterLastFrame = counter; 
    }
    void NewScene()
    {
        timer = timer - Time.deltaTime;
        if(timer < 0)
        {
            foreach (Transform child in frames.transform)
            {
                DestroyImmediate(child.gameObject);
                colorLerp.enabled = true;
            }
            scene2.SetActive(true);
        
            openL_S2.isLerping = true;
            openM_S2.isLerping = true;
            openR_S2.isLerping = true;
            newSceneTrigger = false;

            scene1.SetActive(false);
        }
    }
}
