using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePackageTest : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Toggle the Objects visibility each second
    void Update()
    {
        
    }
}
