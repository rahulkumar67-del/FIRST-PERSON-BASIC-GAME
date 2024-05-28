using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourSystem : MonoBehaviour
{

    Environment enviroment;
    private void Awake()
    {
        enviroment = GetComponent<Environment>();
    }

    private void Update()
    {
        var hitdata = enviroment.ObstacleCheck();
        if (hitdata.forwardHitFound)
        {
            Debug.Log("Obstacel Found" + hitdata.forwardHit.transform.name);
        }
    }
}
