using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingGame : MonoBehaviour
{
    public RaceState raseState;

    public void SimulateRace()
    {
        switch (raseState)
        {
            case RaceState.Start:
                Debug.Log("The race is about to begin. Get ready!");
                break;

            case RaceState.Accelerate:
                Debug.Log("Your press the gas pedal. The car speeds up!");
                break;

            case RaceState.Turn:
                Debug.Log("You approach a sharp turn. Be careful not to crash!");
                break;

            case RaceState.Crash:
                Debug.Log("Your hit a barrier. The race is over");
                break;

            case RaceState.Finish:
                Debug.Log("You crossed the fishish line, Well done!");
                break;

            default:
                Debug.Log("This state is not defined. Something is wrong.");
                break;

        }
    }

    void Start()
    {

    }

    void Update()
    {
        SimulateRace();

    }
}
