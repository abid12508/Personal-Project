using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //set up vector3 for rotation
    [SerializeField] private Vector3 rot;
    //rotate obj every frame
    void Update()
    {
        transform.Rotate(rot * Time.deltaTime * 20);
    }
}
