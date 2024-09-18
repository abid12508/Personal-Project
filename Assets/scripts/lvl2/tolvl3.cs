using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tolvl3 : MonoBehaviour
{

    void OnCollisionEnter(Collision other){

        if(other.gameObject.tag == "next"){
            SceneManager.LoadScene("lvl3");
        }

    }

    
}
