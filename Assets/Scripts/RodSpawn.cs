using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodSpawn : MonoBehaviour
{


    public GameObject RoD;

    public void SpawnRoD()
    {
        Instantiate(RoD);
    }
}
