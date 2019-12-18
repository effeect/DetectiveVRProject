using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool doorOpening = false;

      //Finds all the current values of the levers
    public GameObject lever1; 
    public GameObject lever2;
    public GameObject lever3;

    public GameObject leverResult;

    public bool leverResult1;
    public bool leverResult2;
    public bool leverResult3;
    public bool leverTransfer;

    void Start()
    {
        lever1 = GameObject.Find("Lever1");
        lever2 = GameObject.Find("Lever2");
        lever3 = GameObject.Find("Lever3");
        leverResult = GameObject.Find("SlidingDoor");

    }
    // Update is called once per frame
    
    void Update()
    {
        leverResult1 = lever1.GetComponent<SVLever>().leverIsOn;
        leverResult2 = lever2.GetComponent<SVLever>().leverIsOn;
        leverResult3 = lever3.GetComponent<SVLever>().leverIsOn;

        if(leverResult1 == false && leverResult2 == true && leverResult3 == false)
        {
            doorOpening = true;
            leverResult.GetComponent<DoorAnimationTrigger>().PuzzleComplete = true;
        }
    }
}
