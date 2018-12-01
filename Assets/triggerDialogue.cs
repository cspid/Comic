using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class triggerDialogue : MonoBehaviour {

	public string talkToNode = "";

	// Use this for initialization
	void Start () {
		FindObjectOfType<DialogueRunner>().StartDialogue(talkToNode);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
