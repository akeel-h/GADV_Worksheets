using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    public Material redMaterial;
    public Material greenMaterial;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = redMaterial;
    }

    void Update()
    {
        // Rotate constantly on all axes
        transform.Rotate(new Vector3(50, 50, 50) * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material = greenMaterial;
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material = redMaterial;
    }
}

