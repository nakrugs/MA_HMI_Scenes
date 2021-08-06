using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimationTrigger : MonoBehaviour
{
    public Animator a;

    void OnTriggerEnter(Collider col)
    {
       
        if (col.tag == "Player")
        {
            Debug.Log("ENTERED");
            a.SetTrigger("CarLeavesAnimation");
            a.Play("CarLeavesAnimation");
            Destroy(this);
        }
    }
}
