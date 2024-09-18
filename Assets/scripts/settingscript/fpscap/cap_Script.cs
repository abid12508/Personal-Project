using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cap_Script : MonoBehaviour
{
    public Text fpstxt;
    public Text fpsindicator;

    private static float fpsfloat;



    // Start is called before the first frame update
    void Awake () {

        QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
 
        fpstxt.text = (1/Time.deltaTime).ToString();
        Application.targetFrameRate = Convert.ToInt32(fpsfloat);


        
    }

    public void fps(float FPS){

        fpsfloat = FPS;
        Application.targetFrameRate = Convert.ToInt32(fpsfloat);
        fpsindicator.text = FPS.ToString();
    }
}
