using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luggage : MonoBehaviour
{
    Animator animator;
    public GameObject SteamCooker;
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLuggage()
    {
        if (isOpen == false)
        {
            
            isOpen = true;
            animator.SetTrigger("Trigger");
            SteamCooker.GetComponent<BoxCollider>().enabled = true;
            SoundMgr.Instance.PlaySound(16);
        }
    }
}
