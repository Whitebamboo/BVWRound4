using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class HandPresence_ActionBased : MonoBehaviour
{
    [SerializeField] private ActionBasedController controller;
    [SerializeField] private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Grip", controller.selectAction.action.ReadValue<float>());
        animator.SetFloat("Trigger", controller.activateAction.action.ReadValue<float>());
    }
}
