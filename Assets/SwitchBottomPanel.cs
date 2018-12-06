using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBottomPanel : MonoBehaviour
{

    public AnimManager animManager;



    // Use this for initialization
    public void Switch()
    {
        animManager.switchPanel3Cam2 = true;
    }

    public void Other()
    {
        print("butt");
    }
}
