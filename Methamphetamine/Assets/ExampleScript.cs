using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collider has a rigidbody component
        if (collision.rigidbody != null)
        {
            // Add force to the rigidbody of the collider
            collision.rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has a tag of "Pickup"
        if (other.CompareTag("Pickup"))
        {
            // Disable the collider and renderer components
            other.GetComponent<Collider>().enabled = false;
            other.GetComponent<Renderer>().enabled = false;
        }
    }
}