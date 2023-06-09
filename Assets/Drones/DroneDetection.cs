using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDetection : MonoBehaviour
{

    public Drone Drone;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.parent == Player.Instance.transform)
        {
            Drone.DetectedPlayer(Player.Instance.transform);
            Debug.Log("Detected Player");
        }
        else
        {
            Debug.Log(other.attachedRigidbody.name);
        }
    }

}
