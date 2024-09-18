using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Camera_Save : MonoBehaviour
{
    public static float fov;

    private float resx;
    private float resy;




    public void Fov(string fovInt){

        //convert string to float and assign fov to the fovint
        fov = float.Parse(fovInt, System.Globalization.CultureInfo.InvariantCulture);



        



    }
    
}
