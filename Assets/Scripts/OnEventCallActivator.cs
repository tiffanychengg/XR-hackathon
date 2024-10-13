using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEventCallActivator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject targetObject; // The object to activate/deactivate

    // Method called when the event occurs
    public void DoOnEvent()
    {
        if (targetObject != null)
        {
            bool isActive = targetObject.activeSelf;
            targetObject.SetActive(!isActive); // Toggle active state
            Debug.Log($"{targetObject.name} has been {(isActive ? "deactivated" : "activated")}.");
        }
    }
}


