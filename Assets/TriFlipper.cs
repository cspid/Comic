using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriFlipper : MonoBehaviour
{
    float rotationAmount = 90.0f;
    public bool turn;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        if(turn == true) { 
        transform.Rotate (rotationAmount * Time.deltaTime, 0, 0, Space.Self);
            print(transform.localRotation.x);
            if (transform.localRotation.x >= 100)
            {
                renderer.enabled = false;
                turn = false;
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
    } 
}
