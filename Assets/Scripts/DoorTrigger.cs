using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    Animator animator;
    LeverPuzzle lever;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        lever = GetComponent<LeverPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lever.doorOpening == true)
        {
            animator.SetBool("open", true);
        }
    }
}
