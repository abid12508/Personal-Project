using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Screen.currentResolution);
        
    }

    public void win(bool check){

        if(check){
            Screen.SetResolution(1920, 1080, false);
        }
        else{
            Screen.SetResolution(1920, 1080, true);

        }
    }
}
