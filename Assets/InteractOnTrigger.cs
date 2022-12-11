using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractOnTrigger : MonoBehaviour
{
    [Header("Delete")]
    public GameObject[] toBeDeleted;

    [Header("Enable")]
    public GameObject[] toBeEnabled;

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < toBeDeleted.Length; i++)
        {
            Destroy(toBeDeleted[i]);
        }

        for (int i = 0; i < toBeEnabled.Length; i++)
        {
            toBeEnabled[i].SetActive(true);
        }
    }
}
