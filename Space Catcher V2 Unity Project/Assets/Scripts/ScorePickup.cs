using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    public int pickupValue = 1;

    void OnTriggerEnter3D(Collider other )
    {
        //Score scoreScript = other.GetComponent<score>();
    } 
}

