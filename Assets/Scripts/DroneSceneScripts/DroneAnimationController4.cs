using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationController4 : MonoBehaviour
{
    public GameObject theNPC;

    void Update()
    {
        if (Input.GetButtonDown("Key1"))
        {
            theNPC.GetComponent<Animator>().Play("DroneArrivesWithPackage2");

        }
    }
}
