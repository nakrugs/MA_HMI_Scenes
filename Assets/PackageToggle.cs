using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageToggle : MonoBehaviour
{
    public GameObject Package;
   public void TogglePackage()
    {
        Package.SetActive(false);
    } 
}
