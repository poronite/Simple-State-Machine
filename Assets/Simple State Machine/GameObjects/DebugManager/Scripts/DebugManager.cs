using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    [SerializeField]
    private GameObject DebugCanvas;

    private bool isDebugActive;    

    private void Start()
    {
        SwitchDebug(true);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchDebug(!isDebugActive);
        }
    }

    private void SwitchDebug(bool active)
    {
        isDebugActive = active;

        DebugCanvas.SetActive(active);
    }
}
