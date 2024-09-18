using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class to_Settings : MonoBehaviour
{

    public static bool tolvl1 = false;


    public GameObject main;
    void Update(){

        tp();


    }


    

    void tp(){

        if(Input.GetKeyDown(KeyCode.Escape)){

            tolvl1 = true;

            SceneManager.LoadScene("Settings_scene");
        }
    }
}
