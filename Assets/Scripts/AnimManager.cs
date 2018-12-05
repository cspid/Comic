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
    public bool wakeUp;
	public bool dadLeaves;
	public bool saabOut;
    public bool text1;
    public float left;
	public Transform dadMesh;
	public GameObject[] dadclothes;


	public Transform saab;

    



    // Use this for initialization
    void Start()
    {
		foreach (GameObject t in dadclothes)
		{
			t.SetActive(true);
		}

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
            DialogueRect.offsetMax = new Vector2(/*Right*/ -40, /*Top*/ -145); // <--These values must be inverted

            dialogue.RunDialogue("Intro");
            print("dialogue1");
            text1 = false;
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
    }
}
