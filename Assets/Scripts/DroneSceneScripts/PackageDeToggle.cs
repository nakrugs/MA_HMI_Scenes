using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageDeToggle : MonoBehaviour
{
    public GameObject Package;

    public void TogglePackage()
    {
        Package.SetActive(true);

    }
}
