using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class brightnessscipr : MonoBehaviour
{

    public PostProcessProfile brightness;

    
    public PostProcessLayer layer;

    private AutoExposure exposure;

    public Slider slider;

    void Start(){

       

        brightness.TryGetSettings(out exposure);

    }

    void Update(){

        exposure.keyValue.value = slider.value;        
    }
    
}
