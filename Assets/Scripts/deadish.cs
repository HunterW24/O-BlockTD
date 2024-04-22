using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{
    //Boundary in the X-Axis where the object will be deleted
    public float deletionBoundaryX = 10f;

    private void Update()
    {
        if (transform.position.x > deletionBoundaryX)
        {
            Destroy(gameObject);
        }
    }
}