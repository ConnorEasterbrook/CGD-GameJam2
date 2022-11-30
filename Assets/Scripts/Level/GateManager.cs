using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    public GameObject shortLap;
    public GameObject longLap;


    public static bool gatesComplete;

    public static int lapCount;

    private void Start()
    {
        shortLap.SetActive(true);
        longLap.SetActive(false);
        lapCount = 0;
    }


    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            lapCount += 1;
        }

        //Debug.Log(lapCount);
        if (lapCount == 0)
        {
            if (DetourTrigger.detour)
            {
                shortLap.SetActive(false);
                longLap.SetActive(true);
            }
            if (!DetourTrigger.detour)
            {
                longLap.SetActive(false);
                shortLap.SetActive(true);
            }
        }

        if (lapCount == 1)
        {
                longLap.SetActive(true);
                shortLap.SetActive(false);
        }

        if (lapCount > 1)
        {
            longLap.SetActive(true);
            shortLap.SetActive(false);
        }
    }
}
