using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetourTrigger : MonoBehaviour
{
    public TextMeshPro Text;
    public GameObject Chevrons;
    public GameObject detourBox;
    public static bool detour;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Text.SetText("ROAD AHEAD " + '\n' +
                "    CLOSED");
            Chevrons.SetActive(true);
            //detourBox.SetActive(true);
        }
    }

    
}
