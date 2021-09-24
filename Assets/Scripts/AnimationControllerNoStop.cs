using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerNoStop : MonoBehaviour
{
         public GameObject theNPC;

    void Update()
    {
        if (Input.GetButtonDown("Key1"))
        {
            theNPC.GetComponent<Animator>().Play("ShuttleNoStop 1");
            theNPC.GetComponent<Animator>().Play("CarNoStop");
        }
    }
}

