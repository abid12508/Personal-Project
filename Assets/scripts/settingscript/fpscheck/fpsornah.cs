using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fpsornah : MonoBehaviour
{

    public Text fps;

    public static bool fpsswitch = true;
    
    public void win(bool check){

        if(check){

            fps.gameObject.SetActive(true);
            fpsswitch = true;
        }
        else{

            fps.gameObject.SetActive(false);
            fpsswitch = false;

        }
    }
}
