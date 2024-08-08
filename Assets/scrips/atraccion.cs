using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atraccion : MonoBehaviour
{

    [SerializeField] private ControlData controlData;

    private float f_a;
    private float r_a;


    private void Start()
    {
        
        f_a = controlData.fuerzaAtraccion;
 
        r_a = controlData.radioAtraccion;
    }

    void FixedUpdate()
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position, r_a);

        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.attachedRigidbody;


            if (rb != null && rb.gameObject != gameObject)
            {

                Vector3 direction = transform.position - rb.position;
                float distance = direction.magnitude;

                if (distance == 0f)
                {
                    continue;
                };

                Vector3 gravity = direction.normalized * (f_a / Mathf.Pow(distance, 2));

                rb.AddForce(gravity, ForceMode.Acceleration);

                Vector3 tangentialVelocity = Vector3.Cross(direction.normalized, Vector3.up);
                rb.velocity = Vector3.Lerp(rb.velocity, tangentialVelocity * rb.velocity.magnitude, 0.05f);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, r_a);
    }
}