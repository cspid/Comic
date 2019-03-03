using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youngElinOffsetter : MonoBehaviour
{
    public Transform elin;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(elin.position.x, elin.position.y, elin.position.z +offset);
    }
}
