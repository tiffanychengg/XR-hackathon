using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceZone : MonoBehaviour
{
    // public Vector3 forceDirection = new Vector3(0f, 0f, 1f);
    public float forceMagnitude = 10f;
    public float turbulenceStrength = 0.5f; // Additional random turbulence

    private void OnTriggerStay(Collider other) {
        // If in zone, check if physics object
        // getComponent() to grab its rigid body component and add force
        // figure direction of the force -- take the forward (z green)
        // Check if the other object has a Rigidbody component
        PYObject holder = other.GetComponent<PYObject>();
        if (holder == null) {
            return;
        }
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply force to the Rigidbody
            // Add some random turbulence
            Vector3 randomTurbulence = new Vector3(
                Random.Range(-turbulenceStrength, turbulenceStrength),
                Random.Range(-turbulenceStrength, turbulenceStrength),
                Random.Range(-turbulenceStrength, turbulenceStrength)
            );

            Vector3 force = transform.TransformDirection(Vector3.forward) * forceMagnitude;
            rb.AddForce(force + randomTurbulence);
        }

    }
    // itemID triggers
}
