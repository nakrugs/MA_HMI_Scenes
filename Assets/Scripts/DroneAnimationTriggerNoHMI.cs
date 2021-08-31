using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationTriggerNoHMI : MonoBehaviour
{
    public Animator b;

    private void OnTriggerEnter(Collider col)
    
        {

            if (col.tag == "Player")
            {
                Debug.Log("ENTERED");
            b.SetTrigger("DroneLeavesNoHMI");
                b.Play("DroneLeavesNoHMI");
                Destroy(this);
            }
        }
}
