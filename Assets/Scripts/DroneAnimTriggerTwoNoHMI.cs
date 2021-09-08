using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimTriggerTwoNoHMI : MonoBehaviour
{
    public Animator a;
    // public Animator b;

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            Debug.Log("ENTERED");
            //a.SetTrigger("DroneLeaves");
            a.Play("DroneLeavesNoHMI");
            Destroy(this);
        }
    }
}
