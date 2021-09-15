using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePackage : MonoBehaviour
{

    public GameObject PackageTracker;
        
  
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            PackageTracker.SetActive(false);
        }
    }
}
