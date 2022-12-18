using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugState : MonoBehaviour
{
    [SerializeField]
    private Text debugText;

    private void Update()
    {
        if (Player.PlayerInstance != null)
        {
            debugText.enabled = true;
            debugText.text = Player.PlayerInstance.StateMachine.name + "State: " + Player.PlayerInstance.StateMachine.GetCurrentStateDebug().name;
        }
        else
        {
            debugText.enabled = false;
        }
    }
}
