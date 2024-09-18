using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class tosettings2 : MonoBehaviour
{

    public static bool tolvl2 = false;


    void Update(){

        tp();


    }


    void Start(){

    }


    

    void tp(){

        if(Input.GetKeyDown(KeyCode.Escape)){

            tolvl2 = true;

            SceneManager.LoadScene("Settings_scene");

        
        }
    }
}
