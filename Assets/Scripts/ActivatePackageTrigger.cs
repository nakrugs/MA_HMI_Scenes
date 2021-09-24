using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePackageTrigger : MonoBehaviour
{
    public GameObject Drone;
    public GameObject PackageTracker;
    public Renderer Mesh;

    private void Start()
    {
        //PackageTracker.SetActive(false); 
        PackageTracker.GetComponent<Renderer>().enabled = false;
    }
    
       
    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Drone")
        {
            PackageTracker.GetComponent<Renderer>().enabled = true;
            //PackageTracker.SetActive(true);
            Debug.Log("DroneENTERED");
        }

    }
}
