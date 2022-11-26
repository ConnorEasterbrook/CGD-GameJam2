using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public RespawnManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Debug.Log("Water");
            manager.Crash();
        } 
    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "Obstacle")
    //     {
    //         manager.Crash();
    //     }    
    // }
}
