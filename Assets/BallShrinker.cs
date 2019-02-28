using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;


public class BallShrinker : MonoBehaviour
{
    public float newScale = 0.2f;
    public float newDrag;
    public LookAtIK elinLPaneLookIK;
    float startweight;
    public float lookAwaySpeed = 0.4f;

    void OnEnable()
    {
        elinLPaneLookIK.solver.target = transform;

    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Shrinker Trigger")
        {
            transform.localScale = new Vector3(transform.localScale.x * newScale, transform.localScale.y * newScale, transform.localScale.z * newScale);
            GetComponent<ConstantForce>().force = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().drag = newDrag;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Stop Look Trigger")
        {
            startweight = elinLPaneLookIK.solver.IKPositionWeight;
            elinLPaneLookIK.solver.IKPositionWeight = startweight - Time.deltaTime * lookAwaySpeed;
            print("stop look");
        }
    }
}
