using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is similar to leverPuzzle
public class ButtonPuzzleScript : MonoBehaviour
{
    //Part of the button object
    public GameObject button;
    public bool buttonIsOn;

    public GameObject buttonDoor;
    //This bool serves as a way to work around the 
    public bool OpenOnce;

    void Start()
    {
        button = GameObject.Find("Button1");
        buttonDoor = GameObject.Find("SlidingDoor2");
    }

    // Update is called once per frame
    void Update()
    {
        buttonIsOn = button.GetComponent<SVButton>().buttonPressed;

        if(buttonIsOn)
        {
            buttonDoor.GetComponent<DoorAnimationTrigger>().PuzzleComplete = true;
        }
    }
}
