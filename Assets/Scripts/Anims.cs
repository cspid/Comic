using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Anims : MonoBehaviour
{

    int counter = 0;
    public Animator animator;
    public Camera camera;
    float time;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    [YarnCommand("move")]
    public void Move(string destination)
    {
       // animator.SetTrigger("Go");
        //float time;
        //Color myColor = new Color();
        //Color lerpColor = new Color();
        //ColorUtility.TryParseHtmlString(hexString, out myColor);

     }


}