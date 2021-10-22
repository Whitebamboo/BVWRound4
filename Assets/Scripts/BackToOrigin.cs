using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToOrigin : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 originPos;
    private Quaternion originalRotation;
    void Start()
    {
        originPos = this.transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPos()
    {
        transform.position = originPos;
        transform.rotation = originalRotation;
    }
}
