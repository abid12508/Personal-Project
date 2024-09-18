using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera180 : MonoBehaviour
{

    [SerializeField] private Camera cam;
    void Start()
    {

        cam.transform.Rotate(new Vector3(0f, 180f, 0f));
        
    }

}
