using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    public GeneralInfo General;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Respawn.hitObject = true;

            General.ScoreChange(100f);
        }
    }
}
