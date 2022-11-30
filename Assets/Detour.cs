using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DetourTrigger.detour = true;
        }
    }
}
