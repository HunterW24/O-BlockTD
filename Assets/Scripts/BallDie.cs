using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDie : MonoBehaviour
{
    public string tagToDestroy; // The tag of the GameObject to be destroyed

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collider has the desired tag
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Destroy the collided GameObject
            Destroy(collision.gameObject);
        }
    }
}
