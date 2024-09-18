using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class cam_Saved : MonoBehaviour
{
    public Camera cam;
    //public Camera_Save cs;



    void Start(){


    }

    // Update is called once per frame
    void Update()
    {

        if(Camera_Save.fov < 50f){
            Camera_Save.fov = 50f;
        }
        //make cam fov the same fov we saved in the settings
        cam.fieldOfView = Camera_Save.fov;
        //exposure.keyValue.value = slider_Script.bright_Value;

        
    }


}
