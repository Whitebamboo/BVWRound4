using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence_DeviceBased : MonoBehaviour
{
    [SerializeField] private Animator handAnimator;
    private InputDevice rightController;
    
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        // Get all the devices and print out
        InputDevices.GetDevices(devices);
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        // Get the right controller
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        if (devices.Count > 0)
        {
            rightController = devices[0];
        }
        else
        {
            Debug.LogWarning("Could not find the right controller");
        }

    }

    // Update is called once per frame
    void Update()
    {
        rightController.TryGetFeatureValue(CommonUsages.grip, out float gripValue);
        handAnimator.SetFloat("Grip", gripValue);
        
        rightController.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        handAnimator.SetFloat("Trigger", triggerValue);

    }
    
}
