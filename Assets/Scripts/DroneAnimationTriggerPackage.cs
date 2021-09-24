using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationTriggerPackage : MonoBehaviour
{
    public Animator a;
    // public Animator b;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            Debug.Log("ENTERED");
            //a.SetTrigger("DroneLeavesWithoutPackage");
            a.Play("DroneLeavesWithoutPackage");
            Destroy(this);
        }

    }
    }
