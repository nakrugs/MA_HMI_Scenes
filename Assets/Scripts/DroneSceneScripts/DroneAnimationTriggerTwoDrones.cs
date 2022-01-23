using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationTriggerTwoDrones : MonoBehaviour
{
    public Animator a;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("ENTERED");
            //a.SetTrigger("DroneLeaves");
            a.Play("DroneOneLeaves");
            Destroy(this);
        }
    }

 
  
}
