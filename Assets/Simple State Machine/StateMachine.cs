using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField]
    private State startingState;

    private State currentState;

    private void Start()
    {
        StartStateMachine();
    }

    //It doesn't actually start the state machine but by changing the currentState →
    // → UpdateStateMachine function switches states
    private void StartStateMachine()
    {
        currentState = startingState;
    }

    private void Update()
    {
        UpdateStateMachine();
    }

    private void UpdateStateMachine()
    {
        //If there is a state update it and store the value that it returns
        State nextState = currentState?.UpdateState();

        //If the value that it returns is different from the current state →
        // → it means that the state has changed
        if (nextState != null && currentState != nextState)
        {
            SwitchState(nextState);
        }
    }

    //Exit current state before switching state → Switch state → enter in new state
    private void SwitchState(State nextState)
    {
        currentState.ExitState();

        currentState = nextState;

        currentState.EnterState();
    }


    //Debug - can ignore this
    public State GetCurrentStateDebug()
    {
        return currentState;
    }
}



//Tutorial - How to make a State Machine with this script

//1 - Add this script to the game object (example Player, Game Manager, Enemy AI, etc...)
//2 - Create your states (refer to State.cs to see how to create a State)
//3 - Add the first State's Game Object to the starting state reference in the Game Object with the State Machine
//4 - Done, just run the game and test it.
