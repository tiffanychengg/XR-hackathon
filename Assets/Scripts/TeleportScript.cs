using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    // Public variable to set the teleport location in the Inspector
    public Transform teleportPoint;
    public KeyCode selectedKey;

    // Update is called once per frame
    void Update()
    {
        // Teleport when the Keyboard Letter T is pressed
        if (Input.GetKeyDown(selectedKey))
        {
            gameObject.transform.position = teleportPoint.position;
            Debug.Log("TELEPORT to: " + gameObject.transform.position);
        }
    }
}
