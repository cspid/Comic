using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {
	int blendShapeCount;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;
    float blinkOne;
	//float blendTwo = 0f;
	bool isClosed;
	public float blendSpeed = 1f;
    

	bool blinkFinished;

	public bool blink;

    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        //blendShapeCount = skinnedMesh.blendShapeCount;
    }
	public void StartBlink(){
        skinnedMeshRenderer.SetBlendShapeWeight(0, blinkOne);
        if (isClosed == false)
        {
            blinkOne += blendSpeed;
        }
        if (blinkOne >= 100)
        {
            isClosed = true;
            print("eye closed");
        }
        if (isClosed == true)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(0, blinkOne);
            blinkOne += (-1 * blendSpeed);
            if (blinkOne <= 0)
            {
                blink = false;
                isClosed = false;
            }
        }
	}
    void Update()
    {
		if (blink == true)
		{
			StartBlink();
		}

    }
}
