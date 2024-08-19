using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [SerializeField]
    GameObject parentPoint;
   [SerializeField] GameObject[] Points;

    [SerializeField]  private float movespeed;
    [SerializeField]
    private int pointsIndex;
    // Start is called before the first frame update
    void Start()
    {

        parentPoint = GameObject.FindWithTag("Points");

        /*if (parentPoint != null)
        {
            // Loop through each child in the hierarchy and access them in order
            for (int i = 0; i < parentPoint.transform.childCount; i++)
            {
                // Get the child game object at index 'i'
                GameObject childObject = parentPoint.transform.GetChild(i).gameObject;
                Points[i] = childObject;

                // Do something with the child object, for example, print its name
                //Debug.Log("Child object name: " + childObject.name);
            }
        }*/
        Points = parentPoint.GetComponentsInChildren<GameObject>();

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
