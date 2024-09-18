using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slider_Prefab : MonoBehaviour
{

    public GameObject sliderPrefab;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        save_Slider();
        
    }


    void save_Slider(){
        sliderPrefab.GetComponent<UnityEngine.UI.Slider>().value = slider.value;
    }
    

}
