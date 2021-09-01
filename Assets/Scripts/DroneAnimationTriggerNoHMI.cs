using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationTriggerNoHMI : MonoBehaviour
{
    public Animator a;

    private void OnTriggerEnter(Collider col)
    
        {

            if (col.tag == "Player")
            {
                Debug.Log("ENTERED");
            //a.SetTrigger("DroneLeavesNoHMI");
               a.Play("DroneLeavesNoHMI");
                Destroy(this);
            }
        }
}
