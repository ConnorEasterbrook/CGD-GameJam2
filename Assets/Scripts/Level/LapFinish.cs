using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LapFinish : MonoBehaviour
{
    public GhostLap ghost;

    public GateTrigger GateTrigger;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            ghost.IsRecord = false;
            ghost.isReplay = true;
            if(GateTrigger.Victory != false)
            {
                Debug.Log("victory");
                
                SceneManager.LoadScene(2);
            }
            else if (GateManager.gatesComplete)
            {
                GateManager.lapCount += 1;
                GateManager.gatesComplete = false;
            }
        }
    }
}
