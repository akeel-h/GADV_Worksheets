using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float impulseForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * impulseForce, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * impulseForce, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * impulseForce, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * impulseForce, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
        }
    }
}

