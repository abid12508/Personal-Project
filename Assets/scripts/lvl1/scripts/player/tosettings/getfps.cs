using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getfps : MonoBehaviour
{

    public Text fps;


    void Update(){

        if(fpsornah.fpsswitch == true){
            fps.gameObject.SetActive(true);
        }else{
            fps.gameObject.SetActive(false);
        }

        
    }
}
