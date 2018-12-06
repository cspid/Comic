using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimManager : MonoBehaviour
{

    public Animator middleCamScene1;
    public Animator bottomCamScene1;
    public Animator title;
	public Animator house;
    public Animator houseUp1;
    public Animator FadeInBottomPanel;        
    public Animator BlueIntro;
    public Animator Triggerer;


    public Animator fadeOut;
    public Animator fadeOut2;

    public BorderScript borderScript;
    public triggerDialogue dialogue;

    bool startAnims;
    bool startAnims2;


    //public bool saabAssembly;
    //bool unfurlBottom;
    //public Transform bottomCam;
    ///public Transform DialogueContainer;
    public Transform saab;
    public GameObject[] dadclothes;
    public RectTransform DialogueRect;
    public Text text;
    public Camera panel3Cam2;
    public bool houseIntro;
    public bool openTitle;
    public bool closeTitle;
    public bool wakeUp;
    public bool dadLeaves;
    public bool saabOut;
    public bool text1;
    public bool text2;
    public bool panUp;
    public bool switchPanel3Cam2;
    public bool fade;
    public bool blueIntro;








    // Use this for initialization
    void Start()
    {
		foreach (GameObject t in dadclothes)
		{
			t.SetActive(true);
		}

        dialogue.RunDialogue("Opening");
        openTitle = true;
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
            DialogueRect.offsetMax = new Vector2(/*Right*/ -40, /*Top*/ -145); // <--These values must be inverted

            dialogue.RunDialogue("Intro");
            print("dialogue1");
            text1 = false;
        }

        if (text2 == true)
        {
            text.alignment = TextAnchor.MiddleLeft;
            text.horizontalOverflow = HorizontalWrapMode.Wrap;
            //DialogueRect. = new Vector2(475, -168);
            DialogueRect.offsetMin = new Vector2(/*left*/ 30.4f, /*Bottom*/ 0);
            DialogueRect.offsetMax = new Vector2(/*Right*/ -408, /*Top*/ -295); // <--These values must be inverted

            dialogue.RunDialogue("Commute");
            print("dialogue1");
            text2 = false;
        }

        if (wakeUp == true)
        {
			house.SetTrigger("Wake Up");
			wakeUp = false;
        }

		if (dadLeaves == true)
        {
            house.SetTrigger("Dad Leaves");
			house.SetTrigger("Door open");

            dadLeaves = false;
        }

		if (saabOut == true)
        {
			foreach (GameObject t in dadclothes)
            {
                t.SetActive(false);
            }
            house.SetTrigger("Saab Out");
            house.SetTrigger("Saab Out");
            saabOut = false;
        }    

        if (switchPanel3Cam2 == true){
            panel3Cam2.depth = 2;
          //  FadeInBottomPanel.SetTrigger("Fade");
            switchPanel3Cam2 = false;
        }

        if (fade == true)
        {
            fadeOut.SetTrigger("Fade");
            fadeOut2.SetTrigger("Fade");
            fade = false;
        }

        if (panUp == true){
            middleCamScene1.SetTrigger("Pan Up");
            title.SetTrigger("pan up");
            houseUp1.SetTrigger("Rotate");
            panUp = false;
        }

        if (blueIntro == true)
        {
            BlueIntro.SetTrigger("blue intro");
            blueIntro = false;
        }

        if(startAnims ==true)
        {
            Triggerer.SetTrigger("Triggerer");
            print("2");
        }

        if (startAnims2 == true)
        {
            Triggerer.SetTrigger("Triggerer2");
            print("2");
        }

        //check Text
        if (text.text == "This week has been kinda crazy, it's a long story. "){
            startAnims = true;
            print("1");
        }

        if (text.text == "Most days I wait til i hear his car pull out of the driveway before I get up. It's not that I don't want to see him - I get along pretty well with my dad. ")
        {
            if(Input.GetMouseButton(0)){
                print("Clicked");
                startAnims2 = true;
            }
        }

    }
}
