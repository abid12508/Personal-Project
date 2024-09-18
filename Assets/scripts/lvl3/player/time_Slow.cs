using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time_Slow : MonoBehaviour
{

    public Camera cam;

    


    void Start(){




    void Update()
    {

        Debug.Log(cam.transform.position.z);

        if(Input.GetKeyDown(KeyCode.Space)){

            Time.timeScale = 0.5f;

            if(cam.fieldOfView >= 40){
                cam.fieldOfView -= 1f;

            }
        }
        if(Input.GetKeyUp(KeyCode.Space)){

            if(cam.fieldOfView < Camera_Save.fov){
                cam.fieldOfView += 1f;

            }

            Time.timeScale = 1f;
        }
        
    }
}
}