using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableEvents : MonoBehaviour
{    
    private XRBaseInteractable interactable;

    private void Start() {
        interactable = GetComponent<XRBaseInteractable>();
    }
    
    public void InteractableHighlight(Renderer renderer)
    {
        renderer.material.color = Color.red;
    }
    
    public void InteractorImpluse()
    {
        if (interactable == null) return;
        XRBaseInteractor currentInteractor = interactable.selectingInteractor;
        ActionBasedController controller = interactable.selectingInteractor.GetComponent<ActionBasedController>();
        controller.SendHapticImpulse(0.5f, 0.5f);
    }

    public void InteractableReset(Renderer renderer)
    {
        renderer.material.color = Color.white;
    }
}
