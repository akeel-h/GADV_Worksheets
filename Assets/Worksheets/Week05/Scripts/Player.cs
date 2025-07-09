using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    CharacterController controller;

    public float speed = 6.0f;
    public float radius = 5.0f;
    public float power = 10.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false;
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, transform.position, radius, 1.0f, ForceMode.Impulse);
                }
            }
        }
    }

    void FixedUpdate()
    {
        CheckExplosion();

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);
        controller.Move(move * speed * Time.fixedDeltaTime);
    }
}
