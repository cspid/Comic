using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{

    public Animator middleCamScene1;
    public Animator bottomCamScene1;
    public Animator title;
    public BorderScript borderScript;
    public triggerDialogue dialogue;

    public bool houseIntro;
    public bool saabAssembly;
    bool unfurlBottom;
    public bool openTitle;
    public bool closeTitle;
    public bool blink;
    public bool text1;



    public Transform bottomCam;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (houseIntro == true)
        {
            middleCamScene1.SetTrigger("House Intro");
            houseIntro = false;
        }

        if (saabAssembly == true)
        {
            //bottomCam.GetComponent<Camera>().rect = new Rect(0.03f, 0.02f, 0.94f, 0.3066f);

            bottomCamScene1.SetTrigger("Saab Assembly");
            saabAssembly = false;
        }

        if (unfurlBottom == true)
        {
            //bottomCam.GetComponent<Camera>().rect = new Rect(0.03f, 0.3066f, 0.94f, 0f);
            print("set");
            bottomCam.gameObject.SetActive(true);
            bottomCamScene1.SetTrigger("Unfurl");
            unfurlBottom = false;
        }

        if (openTitle == true)
        {
            print("In");
            title.SetTrigger("In");
        }

        if (closeTitle == true)
        {
            print("out");
            title.SetTrigger("Out");
        }

        if (text1 == true)
        {
            dialogue.RunDialogue("Intro");
            print("dialogue1");
            text1 = false;
        }

        if (blink == true)
        {

        }



    }
}
