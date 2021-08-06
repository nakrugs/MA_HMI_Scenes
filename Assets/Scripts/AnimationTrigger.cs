using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator a;
   // public Animator b;

        void OnTriggerEnter(Collider col)
    {
     // von Dani:  if(col.tag == "Player")
        if(col.tag == "MainCamera")
        {
        Debug.Log("ENTERED");
        a.SetTrigger("ShuttleLeaves");
            a.Play("ShuttleLeaves");
          //  b.SetTrigger("CarLeavesAnimation");
           // b.Play("CarLeavesAnimation");
        Destroy(this);
        }
        
    }
}


  
