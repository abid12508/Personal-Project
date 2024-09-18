using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECUBE : MonoBehaviour
{
    public Transform objectToLookAt;
    
    public GameObject middle;


    void Update()
    {

        
        float degreesPerSecond = 90 * Time.deltaTime;
        Vector3 direction = objectToLookAt.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, degreesPerSecond);

        middle.transform.Rotate(new Vector3(1f,2f,1f),Space.World);

        


    }
}
