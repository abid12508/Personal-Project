using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class go_Back : MonoBehaviour
{

  

    void Start()
    {
        Debug.Log(Screen.currentResolution);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape)){

            if(to_Settings.tolvl1 == true){

                to_Settings.tolvl1 = false;


                SceneManager.LoadScene("lvl1");
            }

            else if(tosettings2.tolvl2 == true){

                tosettings2.tolvl2 = false;


                SceneManager.LoadScene("lvl2");
            }

            else if(to_Settings3.tolvl3 == true){

                to_Settings3.tolvl3 = false;

                SceneManager.LoadScene("lvl3");
            }

            

            else{


                SceneManager.LoadScene("Title_scene");
            }

           


        }

        
        
    }
}
