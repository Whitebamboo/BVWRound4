using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iPad : MonoBehaviour
{

    private bool haveFlashBacked;

    void Start()
    {
        haveFlashBacked = false;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!haveFlashBacked)
        {
            FlashBack();
            haveFlashBacked = true;
        }
    }

    public void FlashBack()
    {
        //TODO
    }
}
