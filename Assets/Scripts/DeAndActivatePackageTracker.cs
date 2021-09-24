using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeAndActivatePackageTracker : MonoBehaviour
{
    public GameObject PackageTracker;

    private void Start()
    {
        PackageTracker.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.B))
        {
            PackageTracker.SetActive(true);
        }
    }
}
