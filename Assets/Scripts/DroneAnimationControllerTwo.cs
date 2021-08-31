using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationControllerTwo : MonoBehaviour
{
    public GameObject theNPC;
    void Update()
    {
        if (Input.GetButtonDown("Key1"))
        {
            theNPC.GetComponent<Animator>().Play("SecondDroneAnimation");
            theNPC.GetComponent<Animator>().Play("DroneOneAnimation");
        }
    }
}
