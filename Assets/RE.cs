using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RE : MonoBehaviour
{
    public Transform objectToLookAt;


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, objectToLookAt.position, 2 * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)){

            gameObject.transform.DetachChildren();
        }

    }
}
