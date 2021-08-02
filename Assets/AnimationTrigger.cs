using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator a;
        void OnTriggerEnter(Collider col)
    {
       if(col.tag == "Player")
        {
        Debug.Log("ENTERED");
        a.SetTrigger("ShuttleLeaves");
            a.Play("ShuttleLeaves");
        Destroy(this);
        }
        
    }
}


  
