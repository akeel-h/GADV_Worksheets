using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamImpulse : MonoBehaviour
{
    public float impulseStrength = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Clockwise rotation around Y-axis (negative torque)
            rb.AddTorque(Vector3.down * impulseStrength, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            // Counter-clockwise rotation around Y-axis (positive torque)
            rb.AddTorque(Vector3.up * impulseStrength, ForceMode.Impulse);
        }
    }
}

