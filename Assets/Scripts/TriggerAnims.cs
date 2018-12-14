using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnims : MonoBehaviour {
    public AnimManager animManager;

	// Use this for initialization
	 public void HouseIntro () {
        animManager.houseIntro = true;
	}

    public void DadLeaving()
    {
        animManager.dadLeaves = true;
    }

    public void WakeUp()
    {
        animManager.wakeUp = true;
    }

    public void OpenTitle()
    {
        animManager.openTitle = true;
    }

    public void CloseTitle()
    {
        animManager.closeTitle = true;
    }

    public void SaabOut()
    {
        animManager.saabOut = true;
    }

    public void Text1()
    {
        animManager.text1 = true;
    }

    public void FadeIn()
    {
        animManager.blueIntro = true;
    }

    public void PanUp()
    {
        animManager.panUp = true;
    }

    public void Fade()
    {
        animManager.fade = true;
    }

    public void Commute()
    {
        animManager.text2 = true;
    }


}
