using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toblue : MonoBehaviour
{


    public Material matb;
    public Material matg;

    public bool b = false;
    public bool g = false;

    public GameObject player;

    void OnCollisionEnter(Collision collider)
    {

        if(collider.gameObject.CompareTag("bb")){

            player.gameObject.GetComponent<MeshRenderer>().material = matb;
            b = true;
            g = false;

        }

        if(collider.gameObject.CompareTag("gg")){

            player.gameObject.GetComponent<MeshRenderer>().material = matg;
            g = true;
            b = false;
        }
        


        Debug.Log("Hit");
    }

    void OnCollisionExit(Collision col)
    {

        Debug.Log("Exit");

    }

}
