using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{

   [SerializeField] Transform[] Points;

    [SerializeField]  private float movespeed;
    [SerializeField]
    private int pointsIndex;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[pointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(pointsIndex <= Points.Length -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[pointsIndex].transform.position, movespeed * Time.deltaTime);
            
            if(Vector3.Distance (transform.position, Points[pointsIndex].transform.position) < 0.1f )
            {
                pointsIndex += 1;
            }


        }
    }
}
