//Based on https://docs.unity3d.com/ScriptReference/Animator.SetTrigger.html

//Thanks to https://www.youtube.com/watch?v=gON_hhhvheI

//This script allows you to trigger an Animator parameter and reset the other that could possibly still be active. Press the up and down arrow keys to do this.

using UnityEngine;

public class DoorAnimationTrigger : MonoBehaviour
{
    private Animator Door_Animator;
    private AudioSource door_sound;
    
    public bool PuzzleComplete = false;
    private bool trigger = false;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        Door_Animator = gameObject.GetComponent<Animator>();
        door_sound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (PuzzleComplete && !trigger)
        {
            // Door_Animator.SetBool("IsAnimating", true);
            Door_Animator.SetTrigger("doorOpen");
            door_sound.Play();
            trigger = true;
        }
    }
}