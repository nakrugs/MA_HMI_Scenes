using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePackageTrigger : MonoBehaviour
{
    public GameObject Drone;
    public GameObject PackageTracker;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Drone")
        {
            PackageTracker.SetActive(false);
            Debug.Log("DroneENTERED");
        }

    }
}
