using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tolvl3 : MonoBehaviour
{
    public GameObject player;
    public Material matb;
    public toblue tb;



    void Update(){


    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Player" && tb.b == true){

            Debug.Log("TP");
            SceneManager.LoadScene("lvl3");
        }

    }
}
