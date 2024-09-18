using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class slider_Script : MonoBehaviour 
{

    public float bright_Value;
    

    [SerializeField]
    private Slider brightnesslider;

    public PostProcessProfile brightness;
    public PostProcessLayer layer;

    private AutoExposure exposure;

    void Start(){

        brightness.TryGetSettings(out exposure);

    }

    public void AdjustBrightness(float value){
        
        exposure.keyValue.value = value;
        bright_Value = value;
        

    }



        


    
    



    
    



}
