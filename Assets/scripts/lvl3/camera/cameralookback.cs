using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralookback : MonoBehaviour
{
    public bool check {get; private set;} = false;
    private Vector3 originalEulerAngles;

    private void Start()
    {
        // Store the initial Euler angles of the camera
        originalEulerAngles = transform.eulerAngles;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle the check flag
            check = !check;

            // Calculate the target Euler angles
            Vector3 targetEulerAngles = check 
                ? new Vector3(originalEulerAngles.x, NormalizeAngle(originalEulerAngles.y + 180f), originalEulerAngles.z)
                : originalEulerAngles;

            // Apply the target Euler angles to the camera
            transform.eulerAngles = targetEulerAngles;
        }
    }

    private float NormalizeAngle(float angle)
    {
        // Normalize angle to be within 0 to 360 degrees
        angle = angle % 360;
        if (angle < 0) angle += 360;
        return angle;
    }
}
