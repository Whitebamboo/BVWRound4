using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Water;
    
    private Animator handlerAnimator;
    private bool isOpen;
    //public GameObject WaterCollider;
    void Start()
    {
        handlerAnimator = GetComponent<Animator>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            Water.GetComponent<PourDetector>().pourCheck = true;
            handlerAnimator.SetBool("open",true);
        }
        else if (!isOpen)
        {
            Water.GetComponent<PourDetector>().pourCheck = false;
            handlerAnimator.SetBool("open", false);
        }
    }
    
}
