using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingCamera : MonoBehaviour
{
    public Transform headLocation;
    public float cameraDistance = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 headPosition = headLocation.position;
        Vector3 cameraSlerp = Vector3.Slerp(transform.position, headPosition, cameraDistance);

        Vector3 headRotation = headLocation.rotation.eulerAngles;
        Quaternion rotationSlerp = Quaternion.Slerp(transform.rotation, Quaternion.Euler(headRotation), 0.25f);

        transform.position = cameraSlerp;
        transform.rotation = rotationSlerp;
    }
}
