using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimManager : MonoBehaviour
{

    public Animator middleCamScene1;
    public Animator bottomCamScene1;
    public Animator title;
    public BorderScript borderScript;
    public triggerDialogue dialogue;

    //public bool saabAssembly;
    //bool unfurlBottom;
    //public Transform bottomCam;
    ///public Transform DialogueContainer;
    public RectTransform DialogueRect;
    public Text text;
    public bool houseIntro;
    public bool openTitle;
    public bool closeTitle;
    public bool blink;
    public bool text1;
    public float left;





    // Use this for initialization
    void Start()
    {
        dialogue.RunDialogue("Opening");
       // DialogueRect = DialogueContainer.GetComponent<RectTransform>
    }

    // Update is called once per frame
    void Update()
    {
        if (houseIntro == true)
        {
            middleCamScene1.SetTrigger("House Intro");
            houseIntro = false;
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
            text.alignment = TextAnchor.MiddleLeft;
            text.horizontalOverflow = HorizontalWrapMode.Wrap;
            //DialogueRect. = new Vector2(475, -168);
            DialogueRect.offsetMin = new Vector2(/*left*/ 475, /*Bottom*/ 0);
            DialogueRect.offsetMax = new Vector2(/*Right*/ -40, /*Top*/ -168); // <--These values must be inverted

            dialogue.RunDialogue("Intro");
            print("dialogue1");
            text1 = false;
        }

        if (blink == true)
        {

        }


        //if (saabAssembly == true)
        //{
        //    //bottomCam.GetComponent<Camera>().rect = new Rect(0.03f, 0.02f, 0.94f, 0.3066f);
        
        //    bottomCamScene1.SetTrigger("Saab Assembly");
        //    saabAssembly = false;
        //}
        
        //if (unfurlBottom == true)
        //{
        //    //bottomCam.GetComponent<Camera>().rect = new Rect(0.03f, 0.3066f, 0.94f, 0f);
        //    print("set");
        //    bottomCam.gameObject.SetActive(true);
        //    bottomCamScene1.SetTrigger("Unfurl");
        //    unfurlBottom = false;
        //}

    }
}
