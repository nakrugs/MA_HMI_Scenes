using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePackageTrigger : MonoBehaviour
{
    public GameObject Drone;
    public GameObject PackageTracker;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Drone")
        {
            PackageTracker.SetActive(true);
            Debug.Log("DroneENTERED");
        }

    }
}
