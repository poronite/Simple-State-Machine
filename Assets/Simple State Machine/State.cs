using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public abstract void EnterState();

    public abstract State UpdateState();

    public abstract void ExitState();
}



//Tutorial - How to create a new state:

//1 - Create a new script
//2 - Make it inherit from this class
//3 - Override the functions
//4 - Type the logic you need in each function
//5 - In the State Machine Game Object create a child and add the new state's script to it
//6 - If new state is the first state to run add the state's game object to StateMachine's startingState reference →
//  → If not you have to write logic in the first state to switch to the new state


//Example of a simple, organized Unity Game Object Hierarchy:

// ➤ "Game Object Name" (Player, Game Manager, etc...) (you can put the State Machine script here)
//  ➤ States (Empty Game Object to group the States)
//   ➤ Idle State (Example of State)
//   ➤ Move State (Example of State)
//   ...
