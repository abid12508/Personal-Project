using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class raydie : MonoBehaviour
{

    void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Player")){

            SceneManager.LoadScene("lvl2");
        }
    }
}
