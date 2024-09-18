using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tolvl2 : MonoBehaviour
{
 
    public GameObject player;
    public Material matb;

    public toblue tb;



    void Update(){


    }

    void OnCollisionEnter(Collision other){

        if(tb.b == true){

            Debug.Log("TP");
            SceneManager.LoadScene("lvl2");
        }

    }

 

    
}
