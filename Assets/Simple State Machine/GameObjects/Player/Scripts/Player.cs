using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleStateMachine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private StateMachine stateMachine;

    public StateMachine StateMachine
    {
        get
        {
            return stateMachine;
        }
    }

    private static Player playerInstance;

    public static Player PlayerInstance
    {
        get
        {
            return playerInstance;
        }
    }

    private void Awake()
    {
        playerInstance = this;
    }

    private void OnDestroy()
    {
        playerInstance = null;
    }
}
