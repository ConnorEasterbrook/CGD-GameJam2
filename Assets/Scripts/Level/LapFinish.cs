using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapFinish : MonoBehaviour
{
    public GhostLap ghost;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            ghost.IsRecord = false;
            ghost.isReplay = true;
            Debug.Log("hello");
        }
    }
}
