using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class to_Settings3 : MonoBehaviour
{

    public static bool tolvl3 = false;


    void Update(){

        tp();


    }


    void Start(){

    }


    

    void tp(){

        if(Input.GetKeyDown(KeyCode.Escape)){

            tolvl3 = true;

            SceneManager.LoadScene("Settings_scene");

        
        }
    }
}
