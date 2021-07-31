using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isAnimating = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Shuttle", true);
        }
    }
}
