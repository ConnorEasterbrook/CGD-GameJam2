using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class RespawnManager : MonoBehaviour
{
    public GameObject player;
    public CarMovement carMovement;
    public Transform defaultSpawn;
    static public Transform currentRespawnPoint;

    public float respawnTime = 3.0f;
    private int countdown = 3;
    private bool crashed;
    private Vector3 playerPosition;
    private Quaternion playerRotation;

    private void Awake()
    {
        currentRespawnPoint = defaultSpawn;

        playerPosition = carMovement.gameObject.transform.position;
        playerRotation = carMovement.gameObject.transform.rotation;
    }

    // private void Update()
    // {
    //     if (crashed)
    //     {
    //         countdown = countdown - Time.deltaTime;
    //         if (countdown <= 0.0f)
    //         {
    //             Respawn();
    //             carMovement.controlsEnabled = true;
    //             countdown = respawnTime;
    //             crashed = false;
    //         }
    //     }
    // }

    public async void Crash()
    {
        Debug.Log("Crash");
        player.gameObject.SetActive(false);
        carMovement.gameObject.transform.position = playerPosition;
        carMovement.gameObject.transform.rotation = playerRotation;
        player.gameObject.SetActive(true);
        carMovement.controlsEnabled = false;

        await Task.Delay(countdown * 1000);
        carMovement.controlsEnabled = true;
        // crashed = true;
    }
}
